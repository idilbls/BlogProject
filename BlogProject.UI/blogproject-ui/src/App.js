import logo from './logo.svg';
import './App.css';
import Profile from './Profile/Profile';
import Article from './Article/Article';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  return (
    <div className='row'>
      <div className='col-8 content'>
      <Article />
      </div>
      <div className='col-4 profile'>
      <Profile />
      </div>      
    </div>
  );
}

export default App;
