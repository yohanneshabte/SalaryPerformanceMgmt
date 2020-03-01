// src/plugins/vuetify.js

import Vue from 'vue'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'
import colors from 'vuetify/lib/util/colors'

Vue.use(Vuetify)


export default new Vuetify({
    theme: {
        themes: {
          light: {
            primary: colors.grey.lighten5,
            secondary: colors.red.lighten4, // #FFCDD2
            accent: colors.indigo.base, // #3F51B5
          },
        },
      },
})