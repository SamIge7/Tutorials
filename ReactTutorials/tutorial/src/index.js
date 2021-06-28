import React from 'react';
import ReactDom from 'react-dom';
import './index.css';

//stateless functional component
//always return JSX

function BookList() {
    return (
        <section class='booklist'>
            <Book />
            <Book />
            <Book />
            <Book />
            <Book />
            <Book />
        </section>
    )
}

const Book = () => {
    return (
        <article>
            <Image />
            <BookTitle />
            <Author />
        </article>
    )
}

const Image = () => (
    <img 
    src='https://images-na.ssl-images-amazon.com/images/I/51CvNtFCbZL._AC_SY780_.jpg'
    alt=''
    />
)

const BookTitle = () => <h1>I Love You To The Moon And Back</h1>;

const Author = () => <h4 style={{color: '#617d98', fontSize: '0.75rem', marginTop: '0.25rem'}}>Amelia Hepworth</h4>;

ReactDom.render(<BookList />, document.getElementById('root'));