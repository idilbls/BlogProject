import React from 'react';  
import { Form, FormGroup, Label, Input, Button, Container } from 'reactstrap'; 
import axios from 'axios';  
import "./Article.css";
import 'bootstrap/dist/css/bootstrap.css';

class Article extends React.Component {
  constructor(props) {  
    super(props);
    this.state = { articles: [] };  
  } 

  componentDidMount() {
    axios.get('https://localhost:44352/api/Article/get_all', {
      headers: {
        'Content-Type': 'application/json'
      }
    })
    .then(response => {
      this.setState({
        articles: response.data                   
      });
    })
    .catch(function (error) {
      console.log(error);
    })
  }

  render() {  
    return (
      <Container className="App col-3">
        <p>Articles</p>
        <div>
          {this.state.articles.map((article) => (
            <div>
            <p>{article.title}</p>
            <p>{article.content}</p>
            <p>{new Date(article.creationDate).toDateString()}</p>
            <ul>
                {article.comments.map((comment) => (
                  <li key={comment.id}>{comment.name}</li>
                ))}
              </ul>
            </div>
          ))}
        </div>
      </Container>
    ); 
  } 
}

export default Article;