import React from 'react';
import ReactDOM from 'react-dom';
import { act } from 'react-dom/test-utils';
import { Counter } from './Counter';

describe('Counter Component', () => {
  let container: HTMLDivElement | null = null;

  beforeEach(() => {
    // Set up a DOM element as a render target
    container = document.createElement('div');
    document.body.appendChild(container);
  });

  afterEach(() => {
    // Clean up on exiting
    if (container) {
      ReactDOM.unmountComponentAtNode(container);
      container.remove();
      container = null;
    }
  });

  it('correctly increments the counter on button click', () => {
    // Render the component
    act(() => {
      ReactDOM.render(<Counter />, container!);
    });

    // Find the button and the display element
    const button = container!.querySelector('button');
    const display = container!.querySelector('strong');

    // Initial count should be 0
    expect(display!.textContent).toBe('0');

    // Simulate a button click
    act(() => {
      button!.dispatchEvent(new MouseEvent('click', { bubbles: true }));
    });

    // After one click, count should be 1
    expect(display!.textContent).toBe('1');
  });
});
