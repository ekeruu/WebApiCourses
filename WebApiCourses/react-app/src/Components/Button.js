// src/components/Button.js
import React from 'react';

function Button({ label, link }) {
    const handleClick = () => {
        window.location.href = link; // Переход по ссылке при клике на кнопку
    };

    return (
        <button onClick={handleClick}>{label}</button>
    );
}

export default Button;
