import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ name, status, mentor, startDate }) {
  const statusStyle = {
    color: status.toLowerCase() === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={statusStyle}>{name}</h3>
      <dl>
        <dt>Status:</dt>
        <dd>{status}</dd>
        <dt>Mentor:</dt>
        <dd>{mentor}</dd>
        <dt>Start Date:</dt>
        <dd>{startDate}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
