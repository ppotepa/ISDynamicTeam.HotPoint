import React from "react";
import { View, Text } from "react-native";
import { Button, ThemeProvider, Badge, Icon } from 'react-native-elements';
import { ReactElementIconType } from "../../types/globaltypes";


export interface MenuItemProps
{   
    localizedLabel:string;
    icon:ReactElementsIcon;
}

export interface MenuItemsState
{
    localizedLabel:string;
    icon:ReactElementIconType;
}

export class MenuItem extends React.Component
{
    constructor(props:MenuItemProps){
        super(props);
           this.state = {
                 localizedLabel:this.props.localizedLabel,
                 icon:this.props.icon
           } 
    }

    props:MenuItemProps;    
    state:MenuItemsState;    
    
    componentDidMount() {}
    updateText = () => {this.setState({localizedLabel:this.state.localizedLabel});};

    render(){
        return (
           <View style={{flex:0.8, margin:20}} onTouchStart={this.updateText} >
                <Text style={{color:'white', textAlignVertical:'top'}}>
                    <Icon name="seaasdrch" onFocus={()=>{alert()}} /> {this.state.localizedLabel}
                </Text>
           </View>
        );
    }   
}
