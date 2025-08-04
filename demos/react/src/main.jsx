import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import { asyncWithFbProvider } from '@featbit/react-client-sdk';

(async () => {
  const config = {
    options: {
      sdkKey: '0Qggs28Ne0GxmetsAsVKZAARL0oKcXNEyYEA2zfCi2vg',
      streamingUri: 'ws://localhost:5100',
      eventsUri: 'http://localhost:5100',
      user: {
        name: 'TestPerson',
        keyId: 'test-person',
        customizedProperties: [{ name: 'isUI', value: 'true' }]
      }
    }
  };

  console.log('Initializing FeatBit with config:', config);
  const root = ReactDOM.createRoot(document.getElementById('root'));
  
  try {
    const FbProvider = await asyncWithFbProvider(config);
    console.log('FeatBit provider initialized successfully');

    root.render(
      <FbProvider>
        <App />
      </FbProvider>
    );
  } catch (error) {
    console.error('FeatBit initialization failed:', error);
    // Render app without FeatBit provider as fallback
    root.render(<App />);
  }

})();
