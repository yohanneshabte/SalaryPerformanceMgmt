
import EmployeeList from './components/profile/EmployeeList.vue';
import EmployeeCard from './components/profile/EmployeeCard.vue';
import Heirarchy from './components/profile/Heirarchy.vue';
import Dashboard from './components/profile/Dashboard.vue';
import PrOverall from './components/profile/PrOverall.vue';
import PerformanceReview from './components/performance/performanceReview.vue';

import Auth from './components/Auth/auth.vue';

//import Login from './components/Login.vue';

const routes = [
    { path: '/', component: EmployeeList },
    { path: '/dashboard', component: Dashboard },
    { path: '/teams', component: Heirarchy },
    { path: '/budget', component: PrOverall },
    { path: '/forms', component: PerformanceReview },
    { path: '/performance', component: PerformanceReview },
    { path: '/employee', component: EmployeeCard },
    { path: '/auth', component: Auth },
];

export default routes;