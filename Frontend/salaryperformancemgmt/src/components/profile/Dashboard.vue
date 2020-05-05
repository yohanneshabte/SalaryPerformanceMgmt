<template>
    <v-container>
        <v-toolbar dense style="">
            <v-toolbar-title>Dashboard</v-toolbar-title>
            <v-spacer></v-spacer>
            <v-toolbar-title>Dashboard</v-toolbar-title>
        </v-toolbar>
        <v-row class="dashboard-card mt-12">
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        to="/"
                        color="purple darken-3"
                        class="white--text"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-home</v-icon>
                            Home
                        </v-card-title>
                    </v-card>
                </v-hover>
            </v-col>
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        to="/employee"
                        color="orange darken-2"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-account-details</v-icon>
                            Employee Management
                        </v-card-title>
                        <ApexChart type="donut" :options="chartOptions" :series="series" width="300"></ApexChart>
                    </v-card>
                </v-hover>
            </v-col>
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        color="green darken-1"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-account-cash</v-icon>
                            Salary Management
                        </v-card-title>
                    </v-card>
                </v-hover>
            </v-col>
        </v-row>
        <v-row>
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        to="/forms"
                        color="red darken-2"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-form-select</v-icon>
                            My Forms
                        </v-card-title>
                        <v-row>
                            <v-col cols="12"><v-sheet height="140" color="red darken-2"></v-sheet></v-col>
                        </v-row>
                        
                        <v-card-actions>
                            <v-list-item class="grow">
                                <v-row
                                align="center"
                                justify="end"
                                class="mr-3"
                                >
                                    <v-badge
                                    color="info"
                                    content="15"
                                    overlap
                                    class="mr-4"
                                    elevation="25"
                                    >
                                        <v-icon elevation="15" class="mr-1" large color="info">mdi-bell</v-icon>
                                    </v-badge>
                                    <span class="mr-1 white--text">·</span>
                                    <v-badge
                                    color="red accent-1"
                                    content="2"
                                    overlap
                                    class="mr-1"
                                    elevation="15"
                                    >
                                        <v-icon elevation="15" class="mr-1" large color="red accent-1">mdi-alert-octagon</v-icon>
                                    </v-badge>
                                </v-row>
                            </v-list-item>
                        </v-card-actions>
                    </v-card>
                </v-hover>
            </v-col>
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        color="cyan darken-2"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-microsoft-teams</v-icon>
                            My Teams
                        </v-card-title>
                        <v-img src="./../../assets/team.png" fill height="200" width="500"></v-img>
                    </v-card>
                    
                </v-hover>
            </v-col>
            <v-col cols="4" class="pa-8">
                <v-hover v-slot:default="{ hover }">
                    <v-card
                        :elevation="hover ? 12 : 2"
                        :class="{ 'on-hover': hover }"
                        to="/reports"
                        color="deep-orange darken-2"
                        height="280"
                        shaped>
                        <v-card-title class="headline white--text font-weight-medium">
                            <v-icon color="white" class="mr-2">mdi-file-chart</v-icon>
                            My Reports
                        </v-card-title>
                        <v-avatar
                            class="ma-3"
                            size="150"
                            tile
                        >
                            <v-img src="./../../assets/donut-chart.png"></v-img>
                        </v-avatar>
                        <v-avatar
                            class="ma-3"
                            size="150"
                            tile
                        >
                            <v-img src="./../../assets/bar-chart.png"></v-img>
                        </v-avatar>
                        <v-avatar
                            class="ma-3"
                            size="150"
                            tile
                        >
                            <v-img src="./../../assets/table.png"></v-img>
                        </v-avatar>
                    </v-card>
                </v-hover>
            </v-col>
        </v-row>
    </v-container>
</template>

<script>
import ApexChart from 'vue-apexcharts'

export default {
    components: {
        ApexChart,
    },
    data () {
        return {
            series: [32, 21, 24, 27],
            chartOptions: {
                labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
                chart: {
                    type: 'donut',
                },
                responsive: [{
                    breakpoint: 400,
                    options: {
                        legend: {
                            show: false
                        }
                    }
                }]
            },
        }
    },
    mounted () {
        
    }

}
</script>

<style scoped>
.v-card {
  transition: opacity 1s ease-in-out;
  cursor: pointer;
}

.v-card:not(.on-hover) {
  opacity: 0.7;
 }
</style>