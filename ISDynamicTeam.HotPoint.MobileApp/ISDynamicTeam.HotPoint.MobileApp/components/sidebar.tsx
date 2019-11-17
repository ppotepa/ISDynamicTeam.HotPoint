import { Component } from "react";
import { Text, View } from "react-native";
import React from "react";
import { Color } from "csstype";
import { MenuItemsList } from "./menu/menuitemslist";

export interface SideBarProps{
    width:string    
}

export default class SideBar extends Component {

    props:SideBarProps;
    render() {
      return (
          <View style={{
            width:this.props.width,
            backgroundColor:'gray',
            flex:1,              
          }}>
            
          <MenuItemsList/>
        </View>
      );    
    }
  }
