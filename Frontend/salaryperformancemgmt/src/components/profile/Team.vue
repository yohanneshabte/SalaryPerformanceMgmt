<template>
 <v-simple-table fixed-header height="250" class="emp-table" background-color="red lighten-2">
    <template v-slot:default>
      <thead>
        <tr class="white--text">
          <th class="white--text text-left body-2 font-weight-bold">Photo</th>
          <th class="white--text text-left body-2 font-weight-bold">Full Name</th>
          <th class="white--text text-left body-2 font-weight-bold">Title</th>
          <th class="white--text text-left body-2 font-weight-bold">Current PR</th>
          <th class="white--text text-left body-2 font-weight-bold">Current Salary</th>
          <th class="white--text text-left body-2 font-weight-bold">Projected PR</th>
          <th class="white--text text-left body-2 font-weight-bold">Salary Raised</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in employees" :key="item.name">
          <td>{{ item.photo }}</td>
          <td>{{ item.fullName }}</td>
          <td>{{ item.title }}</td>
          <td>{{ item.CurrentPR }}</td>
          <td>{{ item.CurrentSalary }}</td>
          <td>{{ item.ProjectedPR }}</td>
          <td>{{ item.SalaryRaised }}</td>
        </tr>
      </tbody>
    </template>
  </v-simple-table>
</template>
<script>
export default {
    name: 'Team',
     data () {
      return {
        employees: [
          {
            photo: '',
            fullName: 'Frankie I. Harris',
            title: 'Senior Systems Architect',
            CurrentPR: 'OP',
            CurrentSalary: '$95,000',
            ProjectedPR: 'OP',
            SalaryRaised: '$5,000',
          },
          {
            photo: '',
            fullName: 'Mary B. Sylva',
            title: 'Supervisor',
            CurrentPR: 'OP',
            CurrentSalary: '$125,000',
            ProjectedPR: 'NA',
            SalaryRaised: '$8,000',
          },
        ],
      }
    },
}
</script>

<style scoped>
.emp-table thead tr th{
    background-color: #e53935 !important;
}
</style>