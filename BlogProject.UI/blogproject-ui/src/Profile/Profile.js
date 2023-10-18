import React from 'react';  
import { Form, FormGroup, Label, Input, Button, Container } from 'reactstrap'; 
import axios from 'axios';  
import "./Profile.css";
import 'bootstrap/dist/css/bootstrap.css';

class Profile extends React.Component{
    constructor(props){  
        super(props)  
        this.state = {
            name: '',
            photoBase64: '',
            birthDate: new Date(),
            info:'',
            email:''
          };
      }   

      componentDidMount(){
        axios.get('https://localhost:44352/api/Profile/get_by_id?id='+1, {
          headers: {
            'Content-Type': 'application/json'
          }
        })
        .then(response=>{
            this.setState({ 
                name: response.data.name,
                photoBase64: response.data.photoBase64,
                birthDate: new Date(response.data.birthDate),
                info: response.data.info,
                email: response.data.email
             });
        })
        .catch(function (error){
            console.log(error);
        })
    }

      render() {  
        return (
          <div>
            <div className='profile-photo'> 
            <img class="photo-inner" src={this.state.photoBase64} alt=""/>
            </div>
            <div className='about-me'>
              <p class="about-me-title"> About Me </p>
              <hr/>
              <p class="about-me-title" style={{ marginBottom: 0}}>Name : </p>
              <p class="about-me-content" style={{ marginBottom: 8}}>{this.state.name.toUpperCase()} </p>
              <p class="about-me-title" style={{ marginBottom: 0}}>Date of Birth : </p>
              <p class="about-me-content" style={{ marginBottom: 8}}>{this.state.birthDate.toDateString()} </p>
            </div>
            <div className='details'>
            <p class="details-title"> Details </p>
              <hr/>
            <p class="details-content" style={{ marginBottom: 8}}>{this.state.info} </p>
            </div>
            <p className='email'>{this.state.email}</p>
          </div>
   
          ); 
        } 
}
export default Profile;  