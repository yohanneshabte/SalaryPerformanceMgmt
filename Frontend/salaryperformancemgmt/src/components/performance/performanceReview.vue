<template>
  <v-container>
    <v-row>
      <v-col cols="2">
        <v-progress-linear v-model="skill" color="blue lighten-1" rounded height="25" reactive>
          <template v-slot="{ value }">
            <strong>{{ Math.ceil(value) }}%</strong>
          </template>
        </v-progress-linear>
      </v-col>
      <v-col cols="8">
        <v-autocomplete
          v-model="friends"
          :disabled="isUpdating"
          :items="people"
          filled
          chips
          color="blue-grey lighten-2"
          label="Select"
          item-text="name"
          item-value="name"
          multiple
        >
          <template v-slot:selection="data">
            <v-chip
              v-bind="data.attrs"
              :input-value="data.selected"
              close
              @click="data.select"
              @click:close="remove(data.item)"
            >
              <v-avatar left>
                <v-img :src="data.item.avatar"></v-img>
              </v-avatar>
              {{ data.item.name }}
            </v-chip>
          </template>
          <template v-slot:item="data">
            <template v-if="typeof data.item !== 'object'">
              <v-list-item-content v-text="data.item"></v-list-item-content>
            </template>
            <template v-else>
              <v-list-item-avatar>
                <img :src="data.item.avatar" />
              </v-list-item-avatar>
              <v-list-item-content>
                <v-list-item-title v-html="data.item.name"></v-list-item-title>
                <v-list-item-subtitle v-html="data.item.group"></v-list-item-subtitle>
              </v-list-item-content>
            </template>
          </template>
        </v-autocomplete>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="2">
        <v-list class="ml-12" width="150">
          <v-list-item v-for="item in items" :key="item.title">
            <v-list-item-icon>
              <v-icon v-if="item.icon" color="green lighten-1">mdi-check</v-icon>
            </v-list-item-icon>

            <v-list-item-avatar>
              <v-img :src="item.avatar"></v-img>
            </v-list-item-avatar>
          </v-list-item>
        </v-list>
      </v-col>
      <v-col cols="8">
        <v-stepper non-linear style="margin-bottom: 2000px;" v-model="e1">
          <v-stepper-header>
            <v-stepper-step editable :complete="e1 > 1" step="1">Enter Employee Info</v-stepper-step>

            <v-divider></v-divider>

            <v-stepper-step editable :complete="e1 > 2" step="2">Add Performance Factors</v-stepper-step>

            <v-divider></v-divider>

            <v-stepper-step step="3" editable>Results & Performance Feedback</v-stepper-step>
          </v-stepper-header>

          <v-stepper-items>
            <v-stepper-content step="1">
              <v-card class="grey lighten-2">
                <v-toolbar flat class="blue lighten-2">
                  <v-icon>mdi-account</v-icon>
                  <v-toolbar-title class="font-weight-light">User Profile</v-toolbar-title>
                  <v-spacer></v-spacer>
                  <v-btn fab small @click="isEditing = !isEditing">
                    <v-icon v-if="isEditing">mdi-close</v-icon>
                    <v-icon v-else>mdi-pencil</v-icon>
                  </v-btn>
                </v-toolbar>
                <v-card-text>
                  <v-text-field
                    :disabled="!isEditing"
                    color="white"
                    label="Employee ID"
                    placeholder="A1234"
                  ></v-text-field>
                  <v-text-field
                    :disabled="!isEditing"
                    color="white"
                    label="Name"
                    placeholder="Sandra Adams"
                  ></v-text-field>
                </v-card-text>
                <v-divider></v-divider>
                <v-card-actions>
                  <v-spacer></v-spacer>
                  <v-btn :disabled="!isEditing" color="success" @click="save">Save</v-btn>
                </v-card-actions>
              </v-card>
              <v-card class="overflow-hidden mt-2" color="grey lighten-2">
                <v-toolbar flat color="grey lighten-2">
                  <v-icon>mdi-arrow-left-bold-circle</v-icon>
                  <v-toolbar-title class="font-weight-light">Previous Reviews</v-toolbar-title>
                </v-toolbar>
                <v-card-text>
                  <v-row>
                  <v-col cols="12 d-flex justify-center">
                    <v-btn flat color="black white--text">Last Rating</v-btn>
                  </v-col>
                  </v-row>
                  <v-row>
                    <v-col cols="12 d-flex justify-center">
                    <v-rating
                      v-model="rating[0]"
                      background-color="white"
                      color="yellow accent-2"
                    ></v-rating>
                    </v-col>
                  </v-row>
                  
                 
                  <v-row>
                  <v-col cols="6 d-flex justify-center">
                    <v-btn flat dense color="black white--text">Rating(06/19)</v-btn>
                    <v-rating
                      v-model="rating[1]"
                      background-color="white"
                      color="yellow accent-2"
                    ></v-rating>
                  </v-col>
                  <v-col cols="6 d-flex justify-center">
                  <v-btn flat dense color="black white--text">Rating(12/18)</v-btn>
                  <v-rating
                    v-model="rating[2]"
                    background-color="white"
                    color="yellow accent-2"
                  ></v-rating>
                  </v-col>
                  </v-row>
                  <v-row>
                  <v-col cols="6 d-flex justify-center">
                    <v-btn flat dense color="black white--text">Rating(06/18)</v-btn>
                    <v-rating
                      v-model="rating[3]"
                      background-color="white"
                      color="yellow accent-2"
                    ></v-rating>
                  </v-col>
                  <v-col cols="6 d-flex justify-center">
                  <v-btn flat dense color="black white--text">Rating(12/17)</v-btn>
                  <v-rating
                    v-model="rating[4]"
                    background-color="white"
                    color="yellow accent-2"
                  ></v-rating>
                  </v-col>
                  </v-row>
                </v-card-text>
                <v-divider></v-divider>
              </v-card>
              <v-btn class="mt-4" color="light-blue accent-3" @click="e1 = 2">Continue</v-btn>

              <v-btn class="mt-4" text>Cancel</v-btn>
            </v-stepper-content>
            <v-stepper-content step="2">
              <v-card class="mb-12 pa-2" color="grey lighten-2">
                <v-row>
                <v-col cols="12" class="title font-weight-light">
                  <header>1. KNOWLEDGE</header>
                </v-col>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Job and Business Knowledge</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Adminstration</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                </v-row>
                <v-row>
                <v-col cols="12" class="title font-weight-light">
                  <v-divider class="mb-4 pt-1 white"></v-divider>
                  <header>2. ENERGY</header>
                </v-col>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Motivation / Drive</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Professional Accountability</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                </v-row>
                <v-row>
                <v-col cols="12" class="title font-weight-light">
                  <v-divider class="mb-4 pt-1 white"></v-divider>
                  <header>3. PASSION</header>
                </v-col>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Commitment</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                <v-col cols="8" class="font-weight-light subtitle-1">
                  <header>Leadership</header>
                </v-col>
                <v-radio-group v-model="row" row>
                  <v-radio label="NI" value="radio-1"></v-radio>
                  <v-radio label="SC" value="radio-2"></v-radio>
                  <v-radio label="EC" value="radio-3"></v-radio>
                </v-radio-group>
                </v-row>
              </v-card>

              <v-btn color="light-blue accent-3" @click="e1 = 3">Continue</v-btn>
            </v-stepper-content>
            <v-stepper-content step="3">
              <v-card class="pa-2 mb-12" color="grey lighten-2" height="200px">
                <v-textarea clearable clear-icon="cancel" label="1. Results" value></v-textarea>
              </v-card>
              <v-card class="pa-2 mb-12 mt-2" color="grey lighten-2" height="200px">
                <v-textarea clearable clear-icon="cancel" label="2. Performance Feedback" value></v-textarea>
              </v-card>

              <v-btn color="light-blue accent-3" @click="e1 = 1">Continue</v-btn>
            </v-stepper-content>
          </v-stepper-items>
        </v-stepper>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: "PerformanceReview",

  data() {
    const items = [
      {
        icon: true,
        title: "Jason Oner",
        avatar: "https://cdn.vuetifyjs.com/images/lists/1.jpg"
      },
      {
        title: "Travis Howard",
        avatar: "https://cdn.vuetifyjs.com/images/lists/2.jpg"
      },
      {
        title: "Ali Connors",
        avatar: "https://cdn.vuetifyjs.com/images/lists/3.jpg"
      },
      {
        title: "Cindy Baker",
        avatar: "https://cdn.vuetifyjs.com/images/lists/4.jpg"
      }
    ];
    const srcs = {
      1: "https://cdn.vuetifyjs.com/images/lists/1.jpg",
      2: "https://cdn.vuetifyjs.com/images/lists/2.jpg",
      3: "https://cdn.vuetifyjs.com/images/lists/3.jpg",
      4: "https://cdn.vuetifyjs.com/images/lists/4.jpg",
      5: "https://cdn.vuetifyjs.com/images/lists/5.jpg"
    };

    return {
      e1: 1,
      items,
      rating: [4, 3, 3, 2, 3],
      autoUpdate: true,
      friends: ["Sandra Adams", "Britta Holt"],
      isUpdating: false,
      name: "Midnight Crew",
      people: [
        { header: "Group 1" },
        { name: "Sandra Adams", group: "Group 1", avatar: srcs[1] },
        { name: "Ali Connors", group: "Group 1", avatar: srcs[2] },
        { name: "Trevor Hansen", group: "Group 1", avatar: srcs[3] },
        { name: "Tucker Smith", group: "Group 1", avatar: srcs[2] },
        { divider: true },
        { header: "Group 2" },
        { name: "Britta Holt", group: "Group 2", avatar: srcs[4] },
        { name: "Jane Smith ", group: "Group 2", avatar: srcs[5] },
        { name: "John Smith", group: "Group 2", avatar: srcs[1] },
        { name: "Sandra Williams", group: "Group 2", avatar: srcs[3] }
      ],
      title: "The summer breeze"
    };
  },
  watch: {
    isUpdating(val) {
      if (val) {
        setTimeout(() => (this.isUpdating = false), 3000);
      }
    }
  },

  methods: {
    remove(item) {
      const index = this.friends.indexOf(item.name);
      if (index >= 0) this.friends.splice(index, 1);
    }
  }
};
</script>
