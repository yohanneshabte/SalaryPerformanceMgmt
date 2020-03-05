<template>
    <v-card class="ml-12 mb-12">
        <v-card-title  class="pt-3 pb-3 black lighten-1 white--text">
            <v-icon color="grey lighten-5" class="mr-6">mdi-finance</v-icon>
            PR OVERALL
            <v-spacer></v-spacer>
        </v-card-title>
        <v-row class="ma-0">
            <v-col cols="9" class="pa-0 text-center title">
                <span>REPORT</span>
            </v-col>
            <v-col cols="3" class="pa-0 text-center title">
                <span>HIGHLIGHTS</span>
            </v-col>
        </v-row>
        <v-row class="ma-0">
            <v-col cols="3" class="pa-1">
                <v-sheet height="250">
                    <ApexChart type="donut" :options="chartOptions" :series="series" width="350"></ApexChart>
                </v-sheet>
            </v-col>
            <v-col cols="3" class="pl-0 ml-0 pa-1 pr-0">
                <v-sheet height="250">
                    <ApexChart type="donut" :options="chartOptions2" :series="series2" width="350"></ApexChart>
                </v-sheet>
            </v-col>
            <v-col cols="3" class="ml-n1 pa-1 pl-0 ">
                <v-sheet height="250">
                    <ApexChart type="donut" :options="chartOptions3" :series="series3" width="350"></ApexChart>
                </v-sheet>
            </v-col>
            <v-divider
                class="pl-4 ml-12"
                vertical
            ></v-divider>
            <v-col cols="2" class="ml-6 pa-1 pl-6">
                <v-sheet height="250">
                    <v-row>
                        <span class="overline">COMPARED TO LAST PERIOD 12/2019</span>
                    </v-row>
                    <v-row class="mt-8">
                        <v-avatar tile color="blue darken-1" size="20">
                            <v-icon dark></v-icon>
                        </v-avatar>
                        <span class="caption ml-2 font-weight-light">46%(+6%)</span>
                    </v-row>
                    <v-row class="mt-4">
                        <v-avatar tile color="green darken-1" size="20">
                            <v-icon dark></v-icon>
                        </v-avatar>
                        <span class="caption ml-2 font-weight-light">14%(-6%)</span>
                    </v-row>
                    <v-row class="mt-4">
                        <v-avatar tile color="yellow darken-3" size="20">
                            <v-icon dark></v-icon>
                        </v-avatar>
                        <span class="caption ml-2 font-weight-light">20%(-5%)</span>
                    </v-row>
                    <v-row class="mt-4">
                        <v-avatar tile color="red lighten-1" size="20">
                            <v-icon dark></v-icon>
                        </v-avatar>
                        <span class="caption ml-2 font-weight-light">20%(+6%)</span>
                    </v-row>
                </v-sheet>
            </v-col>
        </v-row>
    </v-card>
</template>

<script>
import ApexChart from 'vue-apexcharts'

export default {
    name: 'PrOverall',
    components: {
        ApexChart,
    },
    data: function() {
    return {
        series: [32, 21, 24, 27],
        chartOptions: {
            labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
            title: {
                text: '06/2020',
                align: 'center',
            },
            chart: {
                type: 'donut',
            },
            responsive: [{
                breakpoint: 400,
                options: {
                    legend: {
                        position: 'bottom'
                    }
                }
            }]
        },
        series2: [18, 25, 36, 15],
        chartOptions2: {
            labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
            title: {
                text: '12/2019',
                align: 'center',
            },
            chart: {
                type: 'donut',
            },
            responsive: [{
                breakpoint: 400,
                options: {
                    legend: {
                        position: 'bottom'
                    }
                }
            }]
        },
        series3: [12, 24, 32, 28],
        chartOptions3: {
            labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
            title: {
                text: '06/2019',
                align: 'center',
            },
            chart: {
                type: 'donut',
            },
            responsive: [{
                breakpoint: 400,
                options: {
                    legend: {
                        position: 'bottom'
                    }
                }
            }]
        },
    }
  }
}
</script>