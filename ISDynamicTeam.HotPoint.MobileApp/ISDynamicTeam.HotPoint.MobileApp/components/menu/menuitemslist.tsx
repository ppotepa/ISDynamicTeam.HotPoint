import React from "react";
import { View, ScrollView } from "react-native";
import { MenuItem } from "./menuitem";

export class MenuItemsList extends React.Component{
    render(){
        return (
            <ScrollView style={{position:'absolute'}}>

                <MenuItem localizedLabel={`HotPoints`} />    
                <MenuItem localizedLabel={`Znajdź`} />            
                <MenuItem localizedLabel={`Najlepiej oceniane`} /> 
                <MenuItem localizedLabel={`Ustawienia`} />  
                <MenuItem localizedLabel={`Zakończ`} />  

            </ScrollView>
        );
    }
}