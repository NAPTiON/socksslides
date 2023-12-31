{%- comment -%}
  Custom Script for Shopify
{%- endcomment -%}

<script src="https://cdn.jsdelivr.net/npm/canvas-confetti@1.1.1"></script>

// Your first JavaScript code
console.log('Hello from the first script!');

// Your second JavaScript code
console.log('Hello from the second script!');

// Additional JavaScript code using canvas-confetti
document.addEventListener("DOMContentLoaded", function() {
  const headerLink = document.querySelector('.header__heading-link');

  if (headerLink) {
    headerLink.addEventListener("click", function(event) {
      // Prevent the default behavior of the link
      event.preventDefault();

      // Trigger the confetti animation
      confetti({
        particleCount: 100,
        spread: 70,
        origin: { y: 0.6 },
      });

      // You can also navigate to the link's href after the confetti animation if needed
      // window.location.href = headerLink.getAttribute('href');
    });
  }
});
