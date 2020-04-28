<template>
<v-container no-gutters class="ma-0 pa-0">
<v-row no-gutters>
    <v-col cols="12">
        <v-sheet
        height="250"
        tile="false"
        color="grey lighten-2"
        class="pr-data"
        >
        <v-row no-gutters>
            <v-col cols="2">
                <v-sheet
                height="255"
                tile="false"
                class="pt-1"
                color="white"
                >
                    <v-btn color="red darken-1" small elevation="0" height="48" tile class="ma-0 pa-0 width-100">
                        Projected PR Progress
                    </v-btn>
                    <br/><br/><br/>
                    <v-text class="display-3 ml-4">
                        100%
                    </v-text>
                    <br/><br/>
                    <v-btn color="grey darken-1" small rounded class="ml-2">
                        Request Rating
                    </v-btn>
                </v-sheet>
            </v-col>
            <v-col cols="4">
                <v-sheet
                height="255"
                tile="false"
                class="pt-1"
                color="white"
                >
                <v-tabs
                v-model="tab"
                fixed-tabs
                dark
                background-color="grey darken-4"
                show-arrows
                center-active
                >
                <v-tabs-slider color="grey darken-4"></v-tabs-slider>

                <v-tab
                    v-for="i in 5"
                    :key="i"
                    class="pl-12 pr-12"
                >
                    Period 06/202{{ i }}
                </v-tab>
                </v-tabs>
                <v-tabs-items v-model="tab">
                <v-tab-item
                    v-for="i in 5"
                    :key="i"
                >
                    
                </v-tab-item>
                </v-tabs-items>
                <v-row no-gutters>
                        <v-col cols="6" style="border-right: 2px solid lightgrey">
                            <v-btn color="red darken-1" elevation="0" height="40" tile class="ma-0 width-100">
                                Group Rating
                            </v-btn>
                        </v-col>
                        <v-col cols="4">
                            <v-btn color="red darken-1" elevation="0" height="40" tile class="width-100">
                                Percentage 
                            </v-btn>
                        </v-col>
                        <v-col cols="2">
                                <v-btn color="red darken-1" elevation="0" height="40" block tile class="ma-0 pa-0" @click.stop="dialog = true">
                                    <v-icon color="white" medium right>mdi-chart-pie</v-icon>
                                </v-btn>
                        </v-col>
                    </v-row> 
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                        <v-col cols="6">
                            <v-text class="font-weight-medium">OP, EC</v-text>
                        </v-col>
                        <v-col cols="6">
                            <v-text class="font-weight-medium">23%</v-text>
                        </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">SC+</v-text>
                            </v-col>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">37%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">SP, SC</v-text>
                            </v-col>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">35%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="red lighten-3" tile height="40">
                        <v-row>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">UP, NI, SC-</v-text>
                            </v-col>
                            <v-col cols="6">
                                <v-text class="font-weight-medium">5%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>

                </v-sheet>
            </v-col>
            <v-col style="max-width: 2%;">
                <v-sheet
                height="255"
                tile="false"
                color="white"
                >
                <br/><br/><br/><br/><br/>
                <v-btn v-on:click="togglePR" icon class="pa-0 ma-0" x-small>
                <v-icon class="pa-0 ma-0" color="black" x-large>{{navIcon}}</v-icon>
                </v-btn>
                </v-sheet>
            </v-col>
            <transition name="bounce">
            <v-col class="" v-show="extraPR">
                <v-sheet
                height="250"
                tile="false"
                elevation="10"
                class="pa-1 pr-data"
                >
                    <v-row no-gutters>
                        <v-col cols="6" style="border-right: 2px solid lightgrey">
                            <v-btn color="green darken-3" elevation="0" height="48" tile class="ma-0 width-100">
                                Previous Projected PR
                            </v-btn>
                            <v-row no-gutters>
                                <v-col cols="6" style="border-right: 2px solid lightgrey">
                                    <v-btn color="green darken-1" small elevation="0" height="40" tile class="pa-0 width-100">
                                        Group Rating
                                    </v-btn>
                                </v-col>
                                <v-col cols="4">
                                    <v-btn color="green darken-1" x-small elevation="0" height="40" tile class="pa-0 width-100">
                                        Percentage
                                    </v-btn>
                                </v-col>
                                <v-col cols="2">
                                    <v-btn color="green darken-1" elevation="0" height="40" block tile class="ma-0 pa-0" @click.stop="dialog1 = true">
                                        <v-icon color="white" small right>mdi-chart-pie</v-icon>
                                    </v-btn>
                                </v-col>
                            </v-row> 
                            <v-sheet color="green lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                                <v-row>
                                <v-col cols="6" class="pl-8">
                                    <v-text class="font-weight-medium">OP, EC</v-text>
                                </v-col>
                                <v-col cols="6" class="pl-8">
                                    <v-text class="font-weight-medium">23%</v-text>
                                </v-col>
                                </v-row>
                            </v-sheet>
                    <v-sheet color="green lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">SC+</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">37%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="green lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">SP, SC</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">35%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="green lighten-3" tile height="38">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">UP, NI, SC-</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">5%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                        </v-col>
                        <v-col cols="6">
                            <v-btn color="blue darken-3" elevation="0" height="48" tile class="ma-0 width-100">
                                Current PR
                            </v-btn>
                            <v-row no-gutters>
                                <v-col cols="6" style="border-right: 2px solid lightgrey">
                                    <v-btn color="blue darken-1" small elevation="0" height="40" tile class="pa-0 width-100">
                                        Group Rating
                                    </v-btn>
                                </v-col>
                                <v-col cols="4">
                                    <v-btn color="blue darken-1" x-small elevation="0" height="40" tile class="pa-0 width-100">
                                        Percentage
                                    </v-btn>
                                </v-col>
                                <v-col cols="2">
                                    <v-btn color="blue darken-1" elevation="0" height="40" block tile class="ma-0 pa-0" @click.stop="dialog2 = true">
                                        <v-icon color="white" x-small right>mdi-chart-pie</v-icon>
                                    </v-btn>
                                </v-col>
                            </v-row> 
                            <v-sheet color="blue lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                                <v-row>
                                <v-col cols="6" class="pl-8">
                                    <v-text class="font-weight-medium">OP, EC</v-text>
                                </v-col>
                                <v-col cols="6" class="pl-8">
                                    <v-text class="font-weight-medium">23%</v-text>
                                </v-col>
                                </v-row>
                            </v-sheet>
                    <v-sheet color="blue lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">SC+</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">37%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="blue lighten-3" tile height="38" style="border-bottom: 2px solid lightgrey !important;">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">SP, SC</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">35%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                    <v-sheet color="blue lighten-3" tile height="38">
                        <v-row>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">UP, NI, SC-</v-text>
                            </v-col>
                            <v-col cols="6" class="pl-8">
                                <v-text class="font-weight-medium">5%</v-text>
                            </v-col>
                        </v-row>
                    </v-sheet>
                        </v-col>
                    </v-row> 
                </v-sheet>
            </v-col>
            </transition>
        </v-row>
        </v-sheet>
    </v-col>
    
</v-row>
<v-dialog
    v-model="dialog"
    width="550"
>
<v-card elevation="5" class="pa-0 pb-0" max-height= "600">
    <v-card-title class="headline pr-data" center>Performance Guidelines</v-card-title>
    <v-divider></v-divider>
    <GChart
            type="PieChart"
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
<v-dialog
    v-model="dialog1"
    width="550"
>
<v-card elevation="5" class="pa-0 pb-0" max-height= "600">
    <v-card-title class="headline pr-data" center>Performance Guidelines</v-card-title>
    <v-divider></v-divider>
    <GChart
            type="PieChart"
            :data="chartData1"
            :options="chartOptions1"
            class="pa-0"
    />
    <v-card-actions>
    <v-spacer></v-spacer>
    <v-btn
        color="red darken-1"
        text
        @click="dialog1 = false"
    >
        close
    </v-btn>
    </v-card-actions>
</v-card>
</v-dialog>
<v-dialog
    v-model="dialog2"
    width="550"
>
<v-card elevation="5" class="pa-0 pb-0" max-height= "600">
    <v-card-title class="headline pr-data" center>Performance Guidelines</v-card-title>
    <v-divider></v-divider>
    <GChart
            type="PieChart"
            :data="chartData2"
            :options="chartOptions2"
            class="pa-0"
    />
    <v-card-actions>
    <v-spacer></v-spacer>
    <v-btn
        color="red darken-1"
        text
        @click="dialog2 = false"
    >
        close
    </v-btn>
    </v-card-actions>
</v-card>
</v-dialog>
</v-container>
</template>
<script>
export default {
    
    name: 'TeamProjectedPR',
    components: {
    },
    data () {
      
      return {
            navIcon: 'mdi-chevron-right',
            extraPR: false,
            tab: null,
            dialog: false,
            dialog1: false,
            dialog2: false,
            chartData: [['Rating', 'Percentage'],
                        ['OP,EC', 23],
                        ['SC+',  37],
                        ['SP,SC', 35],
                        ['UP,NI,SC-', 5]],
            chartOptions: {
                title: 'PR Period 06/2020',
                colors:['#e53935','#00E676','#1665c0','#01e5ff'],
                titleTextStyle: {fontSize: 18, bold: true},
                subtitle: '06/2020',
                labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
                legend: {alignment: 'center', textStyle: {fontSize: 15, marginBottom: 10}},
                chartArea: {'top':60,'width': '95%', 'height': '90%'},
                height: 450,
                width: 650,
                pieHole: 0.65,
                is3D: true,
            },
            chartData1: [['Rating', 'Percentage'],
                        ['OP,EC', 25],
                        ['SC+',  30],
                        ['SP,SC', 42],
                        ['UP,NI,SC-', 3]],
            chartOptions1: {
                title: 'Previous Projected PR',
                colors:['#e53935','#00E676','#1665c0','#01e5ff'],
                titleTextStyle: {fontSize: 18, bold: true},
                labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
                legend: {alignment: 'center', textStyle: {fontSize: 15, marginBottom: 10}},
                chartArea: {'top':60,'width': '95%', 'height': '90%'},
                height: 450,
                width: 650,
                pieHole: 0.65,
                is3D: true,
            },
            chartData2: [['Rating', 'Percentage'],
                        ['OP,EC', 20],
                        ['SC+',  35],
                        ['SP,SC', 50],
                        ['UP,NI,SC-', 5]],
            chartOptions2: {
                title: 'Current PR',
                colors:['#e53935','#00E676','#1665c0','#01e5ff'],
                titleTextStyle: {fontSize: 18, bold: true},
                labels: ['OP,EC','SC+','SP,SC','UP,NI,SC-'],
                legend: {alignment: 'center', textStyle: {fontSize: 15, marginBottom: 10}},
                chartArea: {'top':60,'width': '95%', 'height': '90%'},
                height: 450,
                width: 650,
                pieHole: 0.65,
                is3D: true,
            },
        }
    },
    methods: {
        togglePR: function() {
            if(this.extraPR == false) {
                this.extraPR = true;
                this.navIcon = 'mdi-chevron-left';
            }
            else {
                this.extraPR = false;
                this.navIcon = 'mdi-chevron-right';
            }
        }
    },
}
</script>

<style scoped>
.emp-sheet {
  border-right: 3px solid lightgray;
}
.width-100 {
    min-width: 100% !important;
}
.btm-border {
    border-bottom: 2px solid lightgrey !important;
}
.pr-data button {
    color: white !important;
}
.pr-data * {
    text-align: center !important;
}
.pr-data v-text {
    font-size: 85%;
}

</style>