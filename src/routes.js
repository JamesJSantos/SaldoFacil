import React from 'react'
import { NavigationContainer } from '@react-navigation/native'
import { createStackNavigator } from '@react-navigation/stack'

const appStack = createStackNavigator();

import Index from './pages/Home'

export default function Routes(){
    return (
        <NavigationContainer>
            <AppStack.Navigator>
                <AppStack.Screen component={Index} />
            </AppStack.Navigator>
        </NavigationContainer>
    )
}