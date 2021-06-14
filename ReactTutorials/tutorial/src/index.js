import React from 'react'
import ReactDom from 'react-dom'

//stateless functional component
//always return JSX

function Greeting() {
    return (
        <div>
            <Person />
            <Message />
        </div>
    );
}

const Person = () => <h2>Hi Sam!</h2>;
const Message = () => {
    return <p>This is my first component!</p>;
};

ReactDom.render(<Greeting />, document.getElementById('root'));