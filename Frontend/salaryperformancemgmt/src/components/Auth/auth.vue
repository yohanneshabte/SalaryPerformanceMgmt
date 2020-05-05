<template>
    <v-content>
        <v-row style="min-height: 800px">
        <v-col cols="1">
        </v-col>
        <v-col
          cols="5"
          id="federated"
          align="center"
          justify="center"
        >
          <v-card style= "min-height: 700px; background: linear-gradient(45deg, #080303 0%, #080303 0%, #000000 30%, #cc1616 100% );">
            <v-img 
              src ="./../../assets/logo.png"
              height="200"
              width="450"


            > </v-img>
          </v-card>
        </v-col>
        <v-col
          cols="3"
          id="login"
          class="pa-0"
        >
          <v-card style= "min-height: 700px" class="pa-6 ma-0">
              <v-card-text class="text-center display-1 font-weight-light">EMPLOYEE PORTAL</v-card-text>
              <v-card-text class="text-center headline font-weight-light">LOGIN</v-card-text>
              
                  <v-form
                    ref="form"
                    v-model="valid"
                    lazy-validation
                    style="margin-top:70px"
                  >
                  <v-alert type="error" border="left" dense v-show="error" class="mb-8" dismissible>
                    {{errorMsg}}
                  </v-alert>
                  <v-text-field 
                    v-model="email"
                    label="Org. Email"
                    name="email"
                    type="email"
                    :rules="emailRules"
                    required
                  ></v-text-field>

                  <v-text-field
                    v-model="empID"
                    id="password"
                    label="Employee ID"
                    name="empID"
                    type="password"
                    :rules="idRules"
                    required
                  ></v-text-field>
                </v-form>
              
                <v-card-actions style="margin-top: 40px; align:center">
                  <v-spacer />
                <v-btn x-large block color="rgba(171,26,37)" dark @click="validate">LOGIN</v-btn>
                
              </v-card-actions>
              <v-card-text class="text-center subtitle-1 font-weight-light">Forgot ID?</v-card-text>
          </v-card>
        </v-col>
      </v-row>
  </v-content>
</template>

<script>
  import {mapGetters} from 'vuex';
  export default {
    props: {
      source: String,
    },
    data: () => ({
      email: '',
      empID: '',
      error: false,
      errorMsg: '',
      valid: false,
      idRules: [
        v => !!v || 'ID is required',
        v => (v && v.length == 6) || 'ID must be 6 characters',
      ],
      emailRules: [
        v => !!v || 'E-mail is required',
        v => /.+@.+\..+/.test(v) || 'E-mail must be valid',
      ],
    }),
    methods: {
        validate () {
          this.$refs.form.validate();
          this.$store.dispatch("changeEmployee",parseInt(this.empID));
          if(this.currentEmployee.firstName == null) {
            this.errorMsg = "Employee ID doesn't exist!";
            this.error = true;
          } else {
            if(this.currentEmployee.email != this.email) {
              this.errorMsg = "Employee ID and Email doesn't match!";
              this.$store.dispatch("changeEmployee", null);
              this.error = true;
            } else {
              // correct sign in
              this.$session.start();
              this.$session.set('email', this.email);
              this.$session.set('empID', this.empID);   
              this.$router.push('/');
            }
          }
      }
    },
    computed: {
      ...mapGetters(['currentEmployeeID','currentEmployee', 'allEmployees']),
      
    }
  }
</script>

<style scoped>

#login {
  
}

#federated {
  margin-left:3vh;
  padding-top:0px;
  padding-bottom: 0px;
}

</style>