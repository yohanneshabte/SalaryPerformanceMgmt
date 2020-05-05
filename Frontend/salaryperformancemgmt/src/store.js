import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        allEmployees: [],
        currentEmployee: null,
        currentEmployeeID: 111111,
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
        }
    },
    actions: {
        changeEmployee({commit, dispatch}, payload) {
            commit("CHANGE_USER", payload);
            dispatch('fetchEmployee');
            dispatch('fetchAllEmployees');
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
        }
    }
});