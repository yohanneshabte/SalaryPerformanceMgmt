<template>
  <v-card class="ml-12">
    <v-card-title>
      Employee List
      <v-spacer></v-spacer>
      <v-text-field 
        v-model="search"
        append-icon="mdi-search"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-data-table
      :headers="headers"
      :items="employees"
      :search="search"
    >
        <template v-slot:item.photo="{ item }">
        <v-avatar color="blue" size="28"><span class="white--text">{{ item.sn }}</span></v-avatar>
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
          { text: 'Email', value: 'email' },
          { text: 'Department', value: 'dept' },
          { text: 'Title', value: 'title' },
          { text: 'PR', value: 'pr' },
          { text: 'Salary', value: 'salary' },
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
            sn: 'JT',
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
            sn: 'PM',
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