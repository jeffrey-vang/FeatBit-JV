import logo from './logo.svg';
import chrlogo from './chr.png';
import {useState} from 'react';
import './App.css';
import { useFlags, useFbClient } from '@featbit/react-client-sdk';

const App = () => {
  const fbClient = useFbClient();
  const [useChrLogo, setUseChrLogo] = useState(fbClient.boolVariation('test', false))

  fbClient.on('update', async (changedKeys) => {
    const updates = await Promise.all(
        changedKeys.map(async (key) => [key, await fbClient.variation(key, '')])
      ).then(pairs => Object.fromEntries(pairs));

    if (Object.keys(updates).length > 0) {
      setUseChrLogo(updates['test'] === true || updates['test'] === 'true');
    }
  });

  //const useChrLogo = flags['test'] === true || flags['test'] === 'true';
  console.log('useChrLogo (converted to boolean):', useChrLogo)
  return (
    <div className="App">
      <header className="App-header">
        <p>{useChrLogo}</p>
        { 
          useChrLogo ? 
          <img src={chrlogo} className="ChrApp-logo" alt="chrlogo" /> :
          <img src={logo} className="App-logo" alt="logo" />
         }
      </header>
    </div>
  );
}

export default App;

