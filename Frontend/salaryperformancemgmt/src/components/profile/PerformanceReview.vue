 <template>
 <v-container no-gutters>
 <v-btn tile flat dark width="250" elevation="0">Performance Review</v-btn>
 <v-row no-gutters>
    <v-col cols="2">
        
        <v-sheet
        class="emp-sheet"
        height="350"
        tile="false"
        >
            <v-btn block tile height="45" class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Last Projected PR</v-btn>
            <v-sheet height="70"></v-sheet>
            <v-text class="display-4 light-blue--text lighten-1">EC</v-text>
            <v-sheet height="103"></v-sheet>
            <v-btn tile elevation="0" block color="white" v-on:click="toggleHistory">
                <v-icon left>{{historyIcon}}</v-icon>
                <v-text class="font-weight-light">Performance Review History</v-text>
            </v-btn>
        </v-sheet>
    </v-col>
    <v-col cols="2">
        <v-sheet
        class="emp-sheet"
        height="350"
        tile="false"
        >
            <v-btn block tile height="45" class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Current PR</v-btn>
            <v-sheet height="70"></v-sheet>
            <v-text class="display-4 font-weight-medium green--text">OP</v-text>
            <v-sheet height="35"></v-sheet>
            <v-text class="font-weight-medium">Last Update 11/29/2019</v-text>
        </v-sheet>
    </v-col>
    <v-col cols="2">
        <v-sheet
        class="emp-sheet"
        height="350"
        tile="false"
        >
            <v-btn block tile height="45" class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Projected PR</v-btn>
            <br/><br/><br/>
            <v-text class="display-4 font-weight-regular red--text">N/A</v-text>
            <v-sheet height="100"></v-sheet>
            <v-btn tile elevation="0" block color="white" class="pa-0 pl-8" v-on:click="toggleDetails1">
            <v-text class="font-weight-light">More Details</v-text>
            <v-icon right>{{detailIcon}}</v-icon>
            </v-btn>
        </v-sheet>
    </v-col>
    <v-col cols="3" v-show="extraDetails1">
        <v-sheet
        class="emp-sheet"
        height="350"
        tile="false"
        color="white"
        elevation="3"
        style="padding: 1%; margin-left: 1%"
        >
            <v-row no-gutters>
                <v-col cols="1">
                    <v-btn block tile height="43" class="pa-0 white--text font-weight-bold" color="red accent-3" elevation="0" v-on:click="toggleDetails1">
                        <v-icon left class="pl-1">mdi-chevron-left</v-icon>  
                    </v-btn>
                </v-col>
                <v-col cols="10">
                    <v-btn block tile height="43" small class="pa-0 white--text font-weight-bold" color="red accent-3" elevation="0">
                        Projected PR Details
                    </v-btn>
                </v-col>
                <v-col cols="1">
                    <v-btn block tile height="43" class="pa-0 white--text font-weight-bold" color="red accent-3" elevation="0" v-on:click="toggleDetails2">
                        <v-icon right class="pr-1">mdi-chevron-right</v-icon>  
                    </v-btn>
                </v-col>
            </v-row>
            <v-sheet height="34" class="title font-weight-medium white--text" color="red lighten-3" tile style="border-bottom: 1px solid lightgrey !important;">Knowledge</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 1px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Adminstration</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">EC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Business Knowledge</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">EC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="34" class="title font-weight-medium white--text" color="red lighten-3" tile style="border-bottom: 2px solid lightgrey !important;">Energy</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Motivation</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">SC+</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Accountability</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">SC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="34" class="title font-weight-medium white--text" color="red lighten-3" tile style="border-bottom: 2px solid lightgrey !important;">Passion</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Commitment</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">EC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Leadership</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">EC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
        </v-sheet>
    </v-col>
    <v-col cols="3" v-show="extraDetails2">
        <v-sheet
        class="emp-sheet"
        height="350"
        tile="false"
        color="white"
        elevation="8"
        style="padding: 1%;"
        >
          <v-row no-gutters>
                <v-col cols="2">
                    <v-btn block tile height="43" class="pa-0 white--text font-weight-bold" color="cyan accent-3" elevation="0" v-on:click="toggleDetails2">
                        <v-icon left class="pl-n12">mdi-chevron-left</v-icon>  
                    </v-btn>
                </v-col>
                <v-col cols="10">
                    <v-btn block left tile height="43" small class="pa-0 white--text font-weight-bold" color="cyan accent-3" elevation="0">
                        Current PR Details
                    </v-btn>
                </v-col>
            </v-row>
            <v-sheet height="34" class="title font-weight-medium white--text" color="cyan lighten-3" tile style="border-bottom: 1px solid lightgrey !important;">Knowledge</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 1px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Adminstration</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">OP</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row class="">
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Business Knowledge</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">SC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="34" class="title font-weight-medium white--text" color="cyan lighten-3" tile style="border-bottom: 2px solid lightgrey !important;">Energy</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Motivation</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">SC+</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Accountability</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">EC</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="34" class="title font-weight-medium white--text" color="cyan lighten-3" tile style="border-bottom: 2px solid lightgrey !important;">Passion</v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Commitment</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">SC+</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
            <v-sheet height="33" color="grey lighten-2" tile style="border-bottom: 2px solid lightgrey !important;">
                <v-row>
                    <v-col cols="8" style="text-align: right">
                        <v-text class="font-weight-regular">Leadership</v-text>
                    </v-col>
                    <v-col cols="4">
                        <v-text class="font-weight-regular">OP</v-text>
                    </v-col>
                </v-row>
            </v-sheet>
        </v-sheet>
    </v-col>
</v-row>
<v-row no-gutters>
    <v-col cols="6" v-show="prhistory">
        <v-sheet 
        height="400"
        tile
        color="white"
        elevation="5"
        >
            <v-row no-gutters>
                <v-col cols="3">
                    <v-btn block tile height="50" class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Factor</v-btn>
                </v-col>
                <v-col cols="3">
                    <v-btn block tile height="50" x-small class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Last Projected PR</v-btn>
                </v-col>
                <v-col cols="2">
                    <v-btn block tile height="50" x-small class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Actual PR</v-btn>
                </v-col>
                <v-col cols="2">
                    <v-btn block tile height="50" x-small class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">Projected PR</v-btn>
                </v-col>
                <v-col cols="1">
                    <v-btn block tile height="50" small class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">
                        <v-icon>mdi-chevron-left</v-icon>
                    </v-btn>
                </v-col>
                <v-col cols="1">
                    <v-btn block tile height="50" small class="pa-0 white--text font-weight-bold" color="blue accent-3" elevation="0">
                        <v-icon>mdi-chevron-right</v-icon>
                    </v-btn>
                </v-col>
            </v-row>
            <v-sheet height="35" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Overall PR
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    SC
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet> 
            <v-sheet class="subtitle-1 pl-4 pt-1 font-weight-medium" height="35" color="light-blue lighten-4" tile>
                Knowledge
            </v-sheet>
            <v-sheet height="35" class="pt-1" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters>
                <v-col cols="3" style="text-align: center;" class="font-weight-bold caption pa-0 ma-0">
                    Business Knowledge
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    SC+
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet>
            <v-sheet height="35" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Administration
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    SC
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    EC
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet>
            <v-sheet class="subtitle-1 pl-4 pt-1 font-weight-medium" height="35" color="light-blue lighten-4" tile>
                Energy
            </v-sheet>
            <v-sheet height="35" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Motivation
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    EC
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet>
            <v-sheet height="35" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Accountability
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    SC+
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    EC
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet>
            <v-sheet class="subtitle-1 pl-4 pt-1 font-weight-medium" height="35" color="light-blue lighten-4" tile>
                Passion
            </v-sheet> 
            <v-sheet height="35" style="border-bottom: 2px solid lightgrey !important;" tile>
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Commitment
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    SC
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    SC
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet> 
            <v-sheet height="35">
            <v-row no-gutters class="pt-1">
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    Leadership
                </v-col>
                <v-col cols="3" style="text-align: center" class="font-weight-bold">
                    SC
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    OP
                </v-col>
                <v-col cols="2" style="text-align: center" class="font-weight-bold">
                    EC
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
                <v-col cols="1" style="text-align: center">
                    
                </v-col>
            </v-row>
            </v-sheet>  
        </v-sheet>
    </v-col>
</v-row>
</v-container>
</template>
<script>
export default {
    name: 'PerformanceReview',
    data () {
        return {
            extraDetails1: false,
            extraDetails2: false,
            prhistory: false,
            historyIcon: 'mdi-chevron-down',
            detailIcon: 'mdi-chevron-right',
        }
    },
    methods: {
        toggleHistory: function() {
            if(this.prhistory == false) {
                this.prhistory = true;
                this.historyIcon = 'mdi-chevron-up';
            }
            else {
                this.prhistory = false;
                this.historyIcon = 'mdi-chevron-down';
            }
        },
        toggleDetails1: function() {
            if(this.extraDetails1 == false) {
                this.extraDetails1 = true;
                this.detailIcon = 'mdi-chevron-left';
            }
            else {
                this.extraDetails1 = false;
                this.detailIcon = 'mdi-chevron-right';
            }
        },
        toggleDetails2: function() {
            if(this.extraDetails2 == false) {
                this.extraDetails2 = true;
            }
            else {
                this.extraDetails2 = false;
            }
        },
    },
}
</script>

<style scoped>
.width-100 {
    min-width: 100% !important;
}
.emp-sheet {
    vertical-align: middle !important;
    text-align: center !important;
}
.title {
    text-align: left !important;
    padding-left: 3%;
}

</style>