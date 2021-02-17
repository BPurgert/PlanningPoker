import React from 'react';

const UserVote = (props) => (
    <div style={{ background: "#eee", borderRadius: '5px', padding: '0 10px' }}>
        <p><strong>{props.user}</strong> says:</p>
        <p>{props.points}</p>
    </div>
);

export default UserVote;