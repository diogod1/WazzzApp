/*import firebase from "firebase/app";
import "firebase/auth";
import "firebase/firestore";*/

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyBgFoG3EuX6CvI-8Q4e4GDQZSVO9kpoXiw",
  authDomain: "projeto-a6414.firebaseapp.com",
  projectId: "projeto-a6414",
  storageBucket: "projeto-a6414.appspot.com",
  messagingSenderId: "849980085652",
  appId: "1:849980085652:web:619c4d3a6d0d18b9336b81",
  measurementId: "G-8975BB0SRR",
};

// Initialize Firebase
const App = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
