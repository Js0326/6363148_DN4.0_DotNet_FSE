import React from 'react';
import './App.css';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div className="App">
      <h1>My Academy Cohorts</h1>
      <CohortDetails name="React Bootcamp" status="ongoing" mentor="Bill Gates " startDate="2025-06-01" />
      <CohortDetails name="Node.js Fundamentals" status="completed" mentor="Elon Musk" startDate="2025-04-01" />
    </div>
  );
}

export default App;
