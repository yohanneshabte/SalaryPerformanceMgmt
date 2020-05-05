import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        allEmployees: [],
        currentEmployee: null,
        currentEmployeeID: null,
        accessType: null,
        salary: null,
        pr: null,
    },
    getters: {
        currentEmployeeID: (state) => state.currentEmployeeID,
        currentEmployee: (state) => state.currentEmployee,
        allEmployees: (state) => state.allEmployees,
        accessType: (state) => state.accessType,
        salary: (state) => state.salary,
        pr: (state) => state.pr,
    },
    mutations: {
        SET_USER(state, payload) {
            state.currentEmployee = payload;
        },
        SET_SALARY(state, payload) {
            state.salary = payload;
        },
        SET_PR(state, payload) {
            state.pr = payload;
        },
        SET_EMPLOYEES(state, payload) {
            state.allEmployees = payload;
        },
        CHANGE_USER(state, payload) {
            state.currentEmployeeID = payload;
        },
        SET_ACCESS_TYPE(state, payload) {
            state.accessType = payload;
        },
    },
    actions: {
        changeEmployee({commit, dispatch}, payload) {
            commit("CHANGE_USER", payload);
            if(this.state.currentEmployeeID != null) {
                dispatch('fetchEmployee');
                dispatch('fetchAllEmployees');
                if(this.state.currentEmployee.poS_ID == 113)
                    commit("SET_ACCESS_TYPE", "supervisor");
                else if(this.state.currentEmployee.poS_ID == 116)
                    commit("SET_ACCESS_TYPE", "cio");
                else if(this.state.currentEmployee.poS_ID == 120)
                    commit("SET_ACCESS_TYPE", "director");
                else
                    commit("SET_ACCESS_TYPE", "staff");
            }
        },
        fetchEmployee({commit}) {
            axios({
                method: "get",
                url: "https://localhost:5001/api/employee/"+this.state.currentEmployeeID,
            })
            .then(response => (commit("SET_USER", response.data)))
            .catch(error => console.log(error));

            axios({
                method: "get",
                url: "https://localhost:5001/api/employee/"+this.state.currentEmployeeID+"/salary",
            })
            .then(response => (commit("SET_SALARY", response.data)))
            .catch(error => console.log(error));

            axios({
                method: "get",
                url: "https://localhost:5001/api/employee/"+this.state.currentEmployeeID+"/performance/review",
            })
            .then(response => (commit("SET_PR", response.data)))
            .catch(error => console.log(error));
        },
        fetchAllEmployees({commit}) {
            axios({
                method: "get",
                url: "https://localhost:5001/api/employee/"+this.state.currentEmployeeID+"/all",
            })
            .then(response => (commit("SET_EMPLOYEES", response.data)))
            .catch(error => console.log(error));
        },
        assignAccess({commit}, payload) {
            commit("SET_ACCESS_TYPE", payload);
        }
    }
});