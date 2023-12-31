console.log('custom-scripts.js has been loaded');
{%- comment -%}
  Custom Script for Shopify
{%- endcomment -%}

<script defer src="https://cdn.jsdelivr.net/npm/canvas-confetti@1.1.1"></script>

<script>
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
</script>