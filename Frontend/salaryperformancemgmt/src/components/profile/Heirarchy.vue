<template>
    <v-card>
        <v-card-title  class="pt-3 pb-3 black lighten-1 white--text">
            <v-icon color="grey lighten-5" class="mr-6">mdi-account-multiple</v-icon>
            TEAM MANAGEMENT
            <v-spacer></v-spacer>
        </v-card-title>
        <v-row ma-0>
            <v-col cols="3" class="ml-2">
                <v-sheet :elevation="1" height="280" color="white">
                    <v-row>
                    <v-avatar class="ml-12 mt-6" size="150">
                        <v-img src="./../../assets/image-3.png" />
                    </v-avatar>
                    </v-row>
                    <v-row>
                    <span class="ml-12 pl-4 mt-4">
                        Terry G. Marshall
                    </span>
                    <span class="ml-12 pl-10 overline">
                        I.S. Manager
                    </span>
                    </v-row>
                </v-sheet>
            </v-col>
            <v-col>
                <v-row>
                    <v-sheet :elevation="6" width="120" height="130" class="" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-2" size="70">
                            <v-img src="./../../assets/image-5.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Nancy H. Forcier
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-10 font-weight-thin">
                         Supervisor
                        </span>
                        </v-row>
                    </v-sheet>
                   
                    <v-sheet :elevation="6" width="110" height="110" class="ml-4 mt-3" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Salina M. Mason
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-4 font-weight-thin">
                         Systems Architect
                        </span>
                        </v-row>
                    </v-sheet>

                    <v-sheet :elevation="6" width="110" height="110" class="ml-4 mt-3" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-6.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Salina M. Mason
                        </span>
                        </v-row>
                        <v-row>
                        <span class="ml-3 font-weight-thin" style="font-size: 8px">
                         Information Security Engineer 1
                        </span>
                        </v-row>
                    </v-sheet>
                </v-row>
                <v-divider class="mt-3"></v-divider>
                <v-row>
                    <v-sheet :elevation="6" width="120" height="130" class="mt-2" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-2" size="70">
                            <v-img src="./../../assets/image-5.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Leonard K. Mark
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-10 font-weight-thin">
                         Supervisor
                        </span>
                        </v-row>
                    </v-sheet>
                    <v-sheet :elevation="6" width="110" height="110" class="mt-4 ml-4" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-7.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-8 mt-1">
                         Eva E. Hicks
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-4 font-weight-thin">
                         System Engineer 5
                        </span>
                        </v-row>
                    </v-sheet>

                    <v-sheet :elevation="6" width="110" height="110" class="mt-4 ml-4" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-14.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-4 mt-1">
                         Thomas D. Lepage
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-3 font-weight-thin">
                         System Developer 1
                        </span>
                        </v-row>
                    </v-sheet>
                </v-row>
            </v-col>
        </v-row>
        <v-row class="grey lighten-3 ma-0">
            <v-col cols="3">
                <v-sheet :elevation="1" height="280" color="white">
                    <v-row>
                    <v-avatar class="ml-12 mt-4" size="150">
                        <v-img src="./../../assets/image-4.png" />
                    </v-avatar>
                    </v-row>
                    <v-row>
                    <span class="ml-12 pl-4 mt-4 center">
                        Peter H. Atkins
                    </span>
                    <span class="ml-6 pl-0 center  overline">
                        Director Business Technology
                    </span>
                    </v-row>
                </v-sheet>
            </v-col>
            <v-col>
                <v-row>
                    <v-sheet :elevation="6" width="120" height="130" class="" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-2" size="70">
                            <v-img src="./../../assets/image-8.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Candy J. Whitfield
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-10 font-weight-thin">
                         Supervisor
                        </span>
                        </v-row>
                    </v-sheet>
                   
                    <v-sheet :elevation="6" width="110" height="110" class="ml-4 mt-3" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-9.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Diana J. Jones
                        </span>
                        </v-row>
                        <v-row>
                        <span class="ml-3 font-weight-thin" style="font-size: 8px">
                         Information Security Engineer 3
                        </span>
                        </v-row>
                    </v-sheet>

                    <v-sheet :elevation="6" width="110" height="110" class="ml-4 mt-3" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-10.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Mary B. Sylva
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-3 font-weight-thin">
                         System Developer 4
                        </span>
                        </v-row>
                    </v-sheet>
                </v-row>
                <v-divider class="mt-3"></v-divider>
                <v-row>
                    <v-sheet :elevation="6" width="120" height="130" class="mt-2" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-2" size="70">
                            <v-img src="./../../assets/image-11.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-2">
                         Janet F. Townsend
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-10 font-weight-thin">
                         Supervisor
                        </span>
                        </v-row>
                    </v-sheet>
                    <v-sheet :elevation="6" width="110" height="110" class="mt-4 ml-4" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-2.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-5 mt-1">
                         Ralph L. Kennedy
                        </span>
                        </v-row>
                        <v-row>
                        <span class="caption ml-4 font-weight-thin">
                         Systems Architect
                        </span>
                        </v-row>
                    </v-sheet>

                    <v-sheet :elevation="6" width="110" height="110" class="mt-4 ml-4" color="grey lighten-5">
                        <v-row>
                            <v-avatar class="ml-8 mt-1" size="60">
                            <v-img src="./../../assets/image-12.png" />
                            </v-avatar>
                        </v-row>
                        <v-row>
                        <span class="caption ml-6 mt-1">
                         Frankie I. Harris
                        </span>
                        </v-row>
                        <v-row>
                        <span class="ml-3 font-weight-thin" style="font-size: 10px">
                         Senior Systems Architect
                        </span>
                        </v-row>
                    </v-sheet>
                </v-row>
            </v-col>
        </v-row>
    </v-card>
</template>
<script>
export default {
    name: 'Heirarchy',
}
</script>
