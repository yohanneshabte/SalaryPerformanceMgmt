<template>
  <v-card class="ml-12">
    <v-card-title  class="pb-0 pt-0 black lighten-1 white--text">
      <v-icon color="grey lighten-5" class="mr-6">mdi-account-group</v-icon>
      EMPLOYEE LIST
      <v-spacer></v-spacer>
      <v-text-field 
        v-model="search"
        append-icon="mdi-search"
        label="Search"
        single-line
        hide-details
        class="ma-0 mb-4"
      ></v-text-field>
    </v-card-title>
    <v-data-table
      :headers="headers"
      :items="employees"
      :search="search"
    >
        <template v-slot:item.photo="{  }">
          <v-avatar size="28"><v-img src="./../../assets/image-11.png" /></v-avatar>
        </template>
        <template v-slot:item.approval="{}">
          <v-row>
            <v-col cols="6">
          <v-btn rounded color="success" x-small><v-icon >mdi-check</v-icon></v-btn>
            </v-col>
            <v-col cols="6">
          <v-btn rounded color="error" x-small><v-icon >mdi-close</v-icon></v-btn>
            </v-col>
          </v-row>
        </template>
    </v-data-table>
        
  </v-card>
</template>


<script>
  export default {
    data () {
      return {
        title: 'Employee List',
        search: '',
        headers: [
          {
            text: 'Photo',
            align: 'left',
            sortable: false,
            value: 'photo',
          },
          { text: 'Employee ID', value: 'employeeID' },
          { text: 'Full Name', value: 'fullName' },
          { text: 'Title', value: 'email' },
          { text: 'Last PR', value: 'dept' },
          { text: 'Current PR', value: 'title' },
          { text: 'Salary', value: 'pr' },
          { text: 'Raise', value: 'salary' },
          {
            text: 'PR Approval',
            sortable: false,
            value: 'approval',
          },
        ],
        employees: [
          {
            photo: '',
            employeeID: 'AA1111',
            fullName: 'Janet F. Townsend',
            email: 'JanetFTownsend@federated.com',
            dept: 'IT',
            title: 'Supervisor',
            pr: 'OP',
            salary: '$90,000',
            sn: '',
          },
          {
            photo: '',
            employeeID: 'AA2222',
            fullName: 'Paul S. Moyer',
            email: 'PaulMoyer@federated.com',
            dept: 'IT',
            title: 'Information Security Engineer 1',
            pr: 'OP',
            salary: '$45,000',
            sn: './../../assets/image-4.png',
          },
          {
            photo: '',
            employeeID: 'AA3333',
            fullName: 'Terry G. Marshall',
            email: 'TerryMarshall@federated.com',
            dept: 'IT',
            title: 'IS Manager',
            pr: 'EC',
            salary: '$110,000',
            sn: 'TM',
          },
          {
            photo: '',
            employeeID: 'AA4444',
            fullName: 'Ralph L. Kennedy',
            email: 'RalphKennedy@federated.com',
            dept: 'IT',
            title: 'System Architect',
            pr: 'EC',
            salary: '$70,000',
            sn: 'RK',
          },
          {
            photo: '',
            employeeID: 'AA5555',
            fullName: 'Mary B. Sylva',
            email: 'CharlottePerkins@federated.com',
            dept: 'IT',
            title: 'Systems Developer 4',
            pr: 'SC+',
            salary: '$51,000',
            sn: 'MS',
          },
          {
            photo: '',
            employeeID: 'AA6666',
            fullName: 'Keshia J Casteli',
            email: 'KeshiaCasteli@federated.com',
            dept: 'IT',
            title: 'Supervisor',
            pr: 'EC',
            salary: '$110,000',
            sn: 'KC',
          },
          {
            photo: '',
            employeeID: 'AA7777',
            fullName: 'Diana J. Jones',
            email: 'DiannaJones@federated.com',
            dept: 'IT',
            title: 'Information Security Engineer 3',
            pr: 'EC',
            salary: '$77,000',
            sn: 'DJ',
          },
          {
            photo: '',
            employeeID: 'AA8888',
            fullName: 'Frankie I. Harris',
            email: 'FrankielHarris@federated.com',
            dept: 'IT',
            title: 'Senior Systems Architect',
            pr: 'OP',
            salary: '$95,000',
            sn: 'FH',
          },
          {
            photo: <v-avatar color="teal" size="48">
      <span class="white--text headline">NF</span>
    </v-avatar>,
            employeeID: 'AA9999',
            fullName: 'Nancy H. Forcier',
            email: 'NancyForcier@federated.com',
            dept: 'IT',
            title: 'Supervisor',
            pr: 'SC',
            salary: '$110,000',
            sn: 'NF',
          },
        ],
      }
    },
  }
</script>