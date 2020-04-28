<template>
<v-row no-gutters>
<v-col cols="12">
        <v-sheet
        height="400"
        tile="false"
        color="grey lighten-2"
        class="pr-data"
        >
        <v-row no-gutters>
            <v-col cols="2">
                <v-sheet
                height="380"
                tile="false"
                class="pt-1"
                >
                    <v-btn block color="red darken-1" small elevation="0" height="48" tile class="ma-0 pa-0 white--text">
                        Projected PR Progress
                    </v-btn>
                    <v-sheet height="70"></v-sheet>
                    <v-text class="display-3 ml-4">
                        100%
                    </v-text>
                    <v-sheet height="100"></v-sheet>
                    <v-btn color="grey darken-1 white--text" x-small rounded class="ml-2">
                        Request Rating
                    </v-btn>
                    <v-sheet height="10"></v-sheet>
                    <v-btn color="blue darken-1 white--text" small rounded class="ml-2">
                        Set Salary Budget
                    </v-btn>
                </v-sheet>
            </v-col>
            <v-col cols="5">
                
                <v-sheet
                height="380"
                tile="false"
                class="pt-1"
                >
                <v-btn block color="black" class="white--text" tile elevation="0" height="48">Period 01/2021</v-btn>
                <v-row no-gutters>
                        <v-col cols="3">
                            <v-btn color="red darken-1" elevation="0" height="40" small tile block class="ma-0 pa-0 white--text" style="border-right: 2px solid white !important;">
                                Group Rating
                            </v-btn>
                        </v-col>
                        <v-col cols="4">
                            <v-btn color="red darken-1" elevation="0" height="40" small tile block class="pa-0 white--text" style="border-right: 2px solid white !important;">
                                Projected Budget 
                            </v-btn>
                        </v-col>
                        <v-col cols="4">
                            <v-btn color="red darken-1" elevation="0" height="40" tile block class="white--text">
                                Budget Used
                            </v-btn>
                        </v-col>
                        <v-col cols="1">
                            <v-btn color="red darken-1" elevation="0" height="40" block tile class="ma-0 pa-0" @click.stop="dialog = true">
                                <v-icon color="white" small right>mdi-graph</v-icon>
                            </v-btn>
                        </v-col>
                    </v-row> 
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-medium">EC</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$3,000</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$2,500</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-medium">OP</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$2,000</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$2,000</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-medium">SC+</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$3,000</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$3,100</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-medium">SC</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$1,500</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$1,500</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-medium">SP</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$500</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-medium">$500</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red white--text" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3">
                            <v-text class="font-weight-bold title">Total</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-bold title">$13,000</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-bold title">$12,500</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-4" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="3" class="white">
                            <v-sheet color="white"></v-sheet>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-bold">BUDGET</v-text>
                        </v-col>
                        <v-col cols="4">
                            <v-text class="font-weight-bold green--text lighten-3" style="font-size: 17px">+$500</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                </v-sheet>
            </v-col>
            <v-col style="max-width: 2%;">
                <v-sheet
                height="380"
                tile="false"
                color="white"
                >
                <v-sheet color="white" height="180"></v-sheet>
                <v-btn v-on:click="togglePR" icon class="pa-0 ma-0" x-small>
                <v-icon class="pa-0 ma-0" color="black" x-large>mdi-chevron-right</v-icon>
                </v-btn>
                </v-sheet>
            </v-col>
        </v-row>
        </v-sheet>
</v-col>
<v-dialog
    v-model="dialog"
    width="850"
>
<v-card elevation="5" class="pa-0 pb-0" max-height= "600">
    <v-card-title class="headline pr-data" center>Budget/Raise Guidelines</v-card-title>
    <v-divider></v-divider>
    <GChart
            type="ColumnChart"
            :data="chartData"
            :options="chartOptions"
            class="pa-0"
    />
    <v-card-actions>
    <v-spacer></v-spacer>
    <v-btn
        color="red darken-1"
        text
        @click="dialog = false"
    >
        close
    </v-btn>
    </v-card-actions>
</v-card>
</v-dialog>
</v-row>
</template>
<script>
export default {
    name: 'TeamProjectedSalary',
    data() {
        return {
            dialog: false,
            chartData: [['Rating', 'Projected Budget','Budget Used'],
                        ['EC', 3000, 2500],
                        ['OP', 2000, 2000],
                        ['SC+', 3000,3100],
                        ['SC', 1500, 1500],
                        ['SP', 500,500]],
            chartOptions: {
                title: 'Period 01/2020',
                colors:['#e53935','#1665c0'],
                titleTextStyle: {fontSize: 18, bold: true},
                legend: {alignment: 'center', textStyle: {fontSize: 15, marginBottom: 10}},
                height: 550,
                width: 850,
                max: 3000,
                annotations: {
                    alwaysOutside: true,
                    textStyle: {
                        fontSize: 14,
                        color: '#000',
                        auraColor: 'none'
                    }
                },
                series: {
                    0: { axis: 'Projected Budget' }, 
                    1: { axis: 'Budget Used' } 
                },
                vAxis: {
                    format: 'currency',
                    title: 'Budget',
                    maxValue: 3200,
                    ticks: [500,1000,1500,2000,2500,3000,3500],
                },
                hAxis: {
                    title: 'Ratings',
                },
                axes: {
                        y: {
                        'Projected Budget': {label: '$1,000s'}, // Left y-axis.
                        'Budget Used': {side: 'right', label: '$1,000s'} // Right y-axis.
                        }
                },
                trendlines: {
                    0: {
                    type: 'linear',
                    color: 'green',
                    lineWidth: 3,
                    opacity: 0.6,
                    showR2: true,
                    visibleInLegend: true
                    },
                    1: {
                    type: 'linear',
                    color: 'green',
                    lineWidth: 3,
                    opacity: 0.6,
                    showR2: true,
                    visibleInLegend: true
                    }
                }
            },
        }
    }
}
</script>

<style scoped>
.emp-sheet {
  border-right: 3px solid lightgray;
}
.pr-data * {
    text-align: center !important;
}
</style>