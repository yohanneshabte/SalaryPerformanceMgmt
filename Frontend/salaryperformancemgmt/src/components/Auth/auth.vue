<template>
  <v-app id="inspire">
    <v-content>
        <v-row >
          
       
        <v-col
          cols="4"
          id="federated"
          align="center"
          justify="center"
        >
          <v-card class="" style= "min-height: 100vh; background: linear-gradient(45deg, #080303 0%, #080303 0%, #000000 30%, #cc1616 100% );">
            <v-img 
              src ="./../../assets/logo.png"
              height="200"
              width="450"


            > </v-img>
          </v-card>
        </v-col>
        <v-col
          cols="4"
          id="login"
        >
          <v-card  style= "min-width: 80vh; min-height: 80vh">
    
              <v-card-text class="title text-center"> Employee Login
                <v-form style="margin-top:70px">
                  <v-text-field 
                    label="Username"
                    name="username"
                    type="text"
                  />

                  <v-text-field
                    id="password"
                    label="Password"
                    name="password"
                    type="password"
                  />
                </v-form>
              </v-card-text>
              <v-card-actions style="margin-top: 40px; align:center">
                  <v-spacer />
                <v-btn x-large color="rgba(171,26,37)" dark>Login</v-btn>
              </v-card-actions>
          </v-card>
        </v-col>

          
        </v-row>
    </v-content>
    
  </v-app>
</template>

<script>
  export default {
    props: {
      source: String,
    },
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