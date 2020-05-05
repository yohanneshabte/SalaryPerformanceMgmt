import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        allEmployees: [],
        currentEmployee: null,
        currentEmployeeID: null,
        accessType: 'staff',
    },
    getters: {
        currentEmployeeID: (state) => state.currentEmployeeID,
        currentEmployee: (state) => state.currentEmployee,
        allEmployees: (state) => state.allEmployees,
        accessType: (state) => state.accessType,
    },
    mutations: {
        SET_USER(state, payload) {
            state.currentEmployee = payload;
        },
        SET_EMPLOYEES(state, payload) {
            state.allEmployees = payload;
        },
        CHANGE_USER(state, payload) {
            state.currentEmployeeID = payload;
        },
        SET_ACCESS_TYPE(state, payload) {
            state.accessType = payload;
        }
    },
    actions: {
        changeEmployee({commit, dispatch}, payload) {
            commit("CHANGE_USER", payload);
            if(this.state.currentEmployeeID != null) {
                dispatch('fetchEmployee');
                dispatch('fetchAllEmployees');
                if(this.state.currentEmployee['poS_ID'] == 113)
                    dispatch('assignAccess', 'supervisor');
                else if(this.state.currentEmployee.poS_ID == 116)
                    dispatch('assignAccess', 'cio');
                else if(this.state.currentEmployee.poS_ID == 120)
                    dispatch('assignAccess', 'director');
            }
        },
        fetchEmployee({commit}) {
            axios({
                method: "get",
                url: "https://localhost:5001/api/employee/"+this.state.currentEmployeeID,
            })
            .then(response => (commit("SET_USER", response.data)))
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