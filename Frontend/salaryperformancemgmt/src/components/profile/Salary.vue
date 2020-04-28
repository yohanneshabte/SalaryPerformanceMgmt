<template>
<v-col>
    <v-btn tile flat dark width="150" elevation="0">Salary</v-btn>
    <v-sheet
    class="emp-sheet"
    height="250"
    tile="false"
    >
    <v-row no-gutters>
      <v-col cols="2">
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="35" class="title" style="text-align: center">
          Previous Salary
        </v-sheet>
        <v-sheet height="5">
        </v-sheet>
        <v-sheet height="50" class="display-2 blue--text lighten-2 font-weight-medium"  style="text-align: center">
          $74,000
        </v-sheet>
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="50" class="title" style="text-align: center">
          Last Projected Salary Raised
        </v-sheet>
        <v-sheet height="10">
        </v-sheet>
        <v-sheet height="50" class="display-2 blue--text lighten-2 font-weight-medium" style="text-align: center">
          $3,700
        </v-sheet>
        <v-sheet height="20">
        </v-sheet>
      </v-col>
      <v-col cols="4">
        <v-sheet height="50">
        </v-sheet>
        <v-sheet height="35" class="title" style="text-align: center">
          Current Salary
        </v-sheet>
        <v-sheet height="20">
        </v-sheet>
        <v-sheet height="80" class="display-3 green--text lighten-2 font-weight-medium" style="text-align: center">
          $110,000
        </v-sheet>
      </v-col>
      <v-col cols="2">
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="30" class="title" style="text-align: center">
          Projected Salary
        </v-sheet>
        <v-sheet height="5">
        </v-sheet>
        <v-sheet height="50" class="display-2 red--text lighten-2 font-weight-medium"  style="text-align: center">
          N/A
        </v-sheet>
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="50" class="title" style="text-align: center">
          Projected Salary Raised
        </v-sheet>
        <v-sheet height="10">
        </v-sheet>
        <v-sheet height="50" class="display-2 red--text lighten-2 font-weight-medium" style="text-align: center">
          N/A
        </v-sheet>
        <v-sheet height="25">
        </v-sheet>
      </v-col>
      <v-col cols="4">
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="30" class="title" style="text-align: center">
          TITLE
        </v-sheet>
        <v-sheet height="5">
        </v-sheet>
        <v-sheet height="50" class="display-1 red--text lighten-2 font-weight-medium"  style="text-align: center">
          Supervisor
        </v-sheet>
        <v-sheet height="15">
        </v-sheet>
        <v-sheet height="30" class="title" style="text-align: center">
          SALARY RANGE
        </v-sheet>
        <v-sheet height="5">
        </v-sheet>
        <v-sheet height="50" class="display-1 red--text lighten-2 font-weight-medium"  style="text-align: center">
          $100,000 - $120,000
        </v-sheet>
        <v-sheet height="10">
        </v-sheet>
        <v-btn tile elevation="0"  color="white" height="40" block right v-on:click="toggleSalaryHistory">
          <v-text class="font-weight-light">Salary History</v-text>
          <v-icon right>{{historyIcon}}</v-icon>
        </v-btn>
      </v-col>
    </v-row>
    </v-sheet>
    <v-simple-table fixed-header class="emp-table" background-color="red lighten-2" v-show="salaryHistory">
    <template v-slot:default>
      <thead>
        <tr class="white--text">
          <th class="white--text text-center text-left body-2 font-weight-bold">Period</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Last Projected Salary Raised</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Pervious Salary</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Actual Salary Raised</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Actual Salary</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Projected Salary Raised</th>
          <th class="white--text text-center text-left body-2 font-weight-bold">Confirmed</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in salary" :key="item.name">
          <td class="text-center">{{ item.period }}</td>
          <td class="text-center">{{ item.lastpsr }}</td>
          <td class="text-center">{{ item.prevsalary }}</td>
          <td class="text-center">{{ item.actsalraised }}</td>
          <td class="text-center">{{ item.actualsalary }}</td>
          <td class="text-center">{{ item.prsalraised }}</td>
          <td class="font-italic caption">{{ item.confirmed }}</td>
        </tr>
      </tbody>
    </template>
  </v-simple-table>
</v-col>
</template>
<script>
export default {
    name: 'Salary',
    data () {
      return {
        salaryHistory: false,
        historyIcon: 'mdi-chevron-down',
        salary: [
          {
            period: '01/2020',
            lastpsr: '$3,700',
            prevsalary: '$74,000',
            actsalraised: '$3,700',
            actualsalary: '$110,000',
            prsalraised: 'N/A',
            confirmed: '01/15/2020 - Supervisor name',
          },
          {
            period: '01/2019',
            lastpsr: '$2,700',
            prevsalary: '$67,300',
            actsalraised: '$3,000',
            actualsalary: '$70,300',
            prsalraised: '$3,700',
            confirmed: '01/09/2019 - Supervisor name',
          },
        ],
      }
    },
    methods: {
      toggleSalaryHistory: function() {
          if(this.salaryHistory == false) {
              this.salaryHistory = true;
              this.historyIcon = 'mdi-chevron-up';
          }
          else {
              this.salaryHistory = false;
              this.historyIcon = 'mdi-chevron-down';
          }
      },
    },
}
</script>

<style scoped>
.salary-tab {
  max-width: 15%;
  max-height: 45px;
}
.emp-table thead tr th{
    background-color: rgb(63, 81, 181) !important;
}
</style>