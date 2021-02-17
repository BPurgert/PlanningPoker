import React from 'react';

import Message from './UserVote';

const VoteWindow = (props) => {
    const chat = props.chat
        .map(m => <Message 
            key={Date.now() * Math.random()}
            user={m.user}
            points={m.points}/>);

    return(
        <div>
            {chat}
        </div>
    )
};

export default VoteWindow;