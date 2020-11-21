import React from 'react';
import { useEffect } from 'react';
import { useRef } from 'react';
import { useState } from 'react';

export default function HooksExample() {
    return (
        <>
            <>
                <UseStateHookExample />
                <UseEffectHookExample />
                <UseRefHookExample />
            </>
        </>
    );
}

function UseStateHookExample() {
    // Объявляем новую переменную состояния "count"
    const [count, setCount] = useState(0);

    return (
        <div>
            <p>Вы кликнули {count} раз</p>
            <button onClick={() => setCount(count + 1)}>
                Нажми на меня
      </button>
        </div>
    );
}

function UseEffectHookExample() {
    const [count, setCount] = useState(0);

    // По принципу componentDidMount и componentDidUpdate:
    useEffect(() => {
        // Обновляем заголовок документа, используя API браузера
        document.title = `Вы нажали ${count} раз`;
    });

    return (
        <div>
            <p>Вы нажали {count} раз</p>
            <button onClick={() => setCount(count + 1)}>
                Нажми на меня
        </button>
        </div>
    );
}

function UseRefHookExample () {
    const inputRef = useRef <HTMLInputElement>(null);

    const onButtonClick = () => {
        inputRef.current?.focus();
    };

    return (
        <div>
            <input ref={inputRef} type="text"></input>
            <button onClick={onButtonClick}>Focus the input</button>
        </div>
    );
}
