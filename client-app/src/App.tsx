import React, { Component } from 'react';
import { Header, Icon, List } from 'semantic-ui-react'
import './App.css';
import { render } from 'react-dom';
import axios from 'axios';

class App extends Component {
  state = {
    weather: []
  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/WeatherForecast')
      .then((response) => {
        this.setState({
          weather: response.data
        })
      })

  }
  render() {
    return (
      <div >
        <Header as='h2'>
          <Icon name='users' />
          <Header.Content>Uptime Guarantee</Header.Content>
        </Header>
        <List>
          {this.state.weather.map((value: any) => (
            <List.Item key={value.id}>{value.summary}</List.Item>
          ))}
        </List>
      </div>
    );
  }
}

export default App;
