import GithubIcon from '../../assets/img/github.svg';
import './styles.css'

export function NavBar(){
  return (
    <header>
      <nav className='container'>
        <div className='dsmovie-nav-content'>
          <h1>DSMovie</h1>
          <a href="">
            <div className='dsmovie-contact-container'>
              <img src={GithubIcon} />
              <p className='dsmovie-contact-link'>/danielpb93</p>
            </div>
          </a>
        </div>
      </nav>
    </header>
  )
}