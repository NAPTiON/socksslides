console.log('custom-scripts.js has been loaded');

// Your first JavaScript code
console.log('Hello from the first script!');

// Your second JavaScript code
console.log('Hello from the second script!');

// Additional JavaScript code using canvas-confetti
window.onload = function() {
    // Trigger the confetti animation
    confetti({
        particleCount: 100,
        spread: 70,
        origin: { y: 0.6 },
    });
};