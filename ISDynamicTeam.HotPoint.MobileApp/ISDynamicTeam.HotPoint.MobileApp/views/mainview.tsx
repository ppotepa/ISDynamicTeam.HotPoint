import React, { Component } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import SideBar from '../components/sidebar';


export class MainView extends React.Component
{
    render() {
        return (
          <View style={{flex:1, backgroundColor:'aliceblue'}}>
           <SideBar width={'200px'}/>           
          </View>
        );
      }
} 
    


