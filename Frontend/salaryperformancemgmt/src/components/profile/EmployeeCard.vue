<template>
  <!-- <v-card class="d-inline-block mx-auto">
    <v-container>
      <v-row justify="space-between">
        <v-col cols="auto">
          <v-img
            height="200"
            width="200"
            src=""
          ></v-img>
        </v-col>

        <v-col
          cols="auto"
          class="text-center pl-0"
        >
          <v-row
            class="flex-column ma-0 fill-height"
            justify="center"
          >
            <v-col class="px-0">
                <span class="red">EMPLOYEE ID</span>
                <span>AC2386</span>
                <span class="red">FULL NAME</span>
                <span>Frankie Issac Harris</span>
              <v-btn icon>
                <v-icon>mdi-heart</v-icon>
              </v-btn>
            </v-col>

            <v-col class="px-0">
              <v-btn icon>
                <v-icon>mdi-bookmark</v-icon>
              </v-btn>
            </v-col>

            <v-col class="px-0">
              <v-btn icon>
                <v-icon>mdi-share-variant</v-icon>
              </v-btn>
            </v-col>
          </v-row>
        </v-col>
      </v-row>
    </v-container>
  </v-card> -->
<v-container>
  <v-row no-gutters>
    <v-toolbar dense class="mb-12">
      <v-toolbar-title>Employee Management</v-toolbar-title>
      <v-spacer></v-spacer>
      <v-toolbar-title>Home > Employee Management</v-toolbar-title>
    </v-toolbar>
    <v-col cols="11" no-gutters class="emp-nav ml-12">
    <v-toolbar dense color="grey darken-3" class="ml-12">
      <v-btn class="ma-2 pl-0 pr-0" color="blue" width="250" right>
       <v-avatar size="30" left>
      <img :src="require('./../../assets/' + currentEmployee.profilePic)" /> 
      </v-avatar>
      {{currentEmployee.firstName + " "+ currentEmployee.middleName + ". "+ currentEmployee.lastName}}
      <v-icon right>mdi-dots-vertical</v-icon>
      </v-btn>
      <v-btn rounded class="ma-2 pl-0 pr-0" outlined color="blue" width="250" right>
       <v-avatar size="30" left>
      <img src="./../../assets/image-5.png" /> 
      </v-avatar>
      Candy J. Whitefield
      <v-icon right>mdi-dots-vertical</v-icon>
    </v-btn>
    </v-toolbar>
     
    </v-col>
  </v-row>
  <v-row>
    <v-col cols="3" class="pl-0">
      <v-card
        max-width="344"
        class="mx-auto employee-card"
      >
        <v-list-item>
          <v-list-item-avatar color="grey"><img :src="require('./../../assets/' + currentEmployee.profilePic)"/></v-list-item-avatar>
          <v-list-item-content>
            <v-list-item-title class="overline">EMPLOYEE INFORMATION</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
        <v-avatar color="blue darken-2" tile height="220" style="min-width: 100%">
        <v-img
          :src="require('./../../assets/' + currentEmployee.profilePic)"
          height="125"
          contain
        ></v-img>
        </v-avatar>
        <v-list>
          <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-card-account-details</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{currentEmployee.emP_ID}}</v-list-item-title>
                <v-list-item-subtitle>Employee ID</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
          <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-briefcase</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{salary.position.posTitle}}</v-list-item-title>
                <v-list-item-subtitle>Title</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
          <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-account-box</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{currentEmployee.firstName + " "+ currentEmployee.middleName + ". "+ currentEmployee.lastName}}</v-list-item-title>
                <v-list-item-subtitle>Full Name</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
           <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-email</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{currentEmployee.email}}</v-list-item-title>
                <v-list-item-subtitle>Email</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
          <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-star</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{pr.currentPR.ratingName}}</v-list-item-title>
                <v-list-item-subtitle>Current PR</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
          <v-list-item>
              <v-list-item-icon>
                <v-icon color="indigo">mdi-currency-usd</v-icon>
              </v-list-item-icon>

              <v-list-item-content>
                <v-list-item-title>{{salary.salary.salary}}</v-list-item-title>
                <v-list-item-subtitle>Current Salary</v-list-item-subtitle>
              </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-card>
    </v-col>
    <v-col cols="9" class="pt-0">
      <v-col>
     <v-tabs
      v-model="tab"
      background-color="grey darken-1"
      dark
      x-small
      fixed-tabs
      center-active
      class="employee-tabs"
      active-class="background-color: black"
    >
      <v-tab
        v-for="item in items"
        :key="item.tab"
      >
        {{ item.tab }}
      </v-tab>
    </v-tabs>
    <v-tabs-items v-model="tab">
      <v-tab-item
        v-for="item in items"
        :key="item.tab"
      >
          <component :is="item.component"></component>  
      </v-tab-item>
    </v-tabs-items>
      </v-col>   
      <br/>
      <Salary />
      
      <PerformanceReview />
    </v-col>
  </v-row>
  </v-container>
</template>

<script>
import TeamProjectedPR from './TeamProjectedPR';
import TeamProjectedSalary from './TeamProjectedSalary';
import Team from './Team';
import Salary from './Salary';
import PerformanceReview from './PerformanceReview';
import {mapGetters} from 'vuex';

export default {
  name: 'EmployeeCard',
  props: ['id'],
  components: {
    TeamProjectedPR,
    TeamProjectedSalary,
    Team,
    Salary,
    PerformanceReview,
  },
  
  data() {
    return {
      tab: null,
      items: [
          { tab: 'TEAM PROJECTED PR', component: TeamProjectedPR },
          { tab: 'TEAM PROJECTED SALARY', component: TeamProjectedSalary },
          { tab: 'TEAM', component: Team },
       ],
      other: {firstName: 'win'},
      employee: null,
      employeeHeirarchy: [
        {
          text: 'Peter H. Atkins',
          disabled: false,
          href: '#/employee',
        },
        {
          text: 'Candy J. Whitefield',
          disabled: false,
          href: '#/employee',
        },
        {
          text: 'Diana J. Jones',
          disabled: true,
          href: '#/employee',
        },
  ],
    }
  },
    computed: {
      ...mapGetters(['currentEmployeeID','currentEmployee', 'allEmployees', 'salary', 'pr']),
      
    },
    mounted () {
      this.employee = this.id==null?this.currentEmployee:this.other;
    }
}
</script>

<style scoped>
.employee-card {
  min-height: 500px;
}
.employee-tabs {

  max-height: 45px;
}
.salary-tab {
  max-width: 15%;
  max-height: 45px;
}
.per-tab {
  max-width: 20%;
  max-height: 45px;
}
.breadcrumb {
  background-color: red;
}
.emp-nav v-avatar{

}
</style>

