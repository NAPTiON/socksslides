﻿
/* Color custom properties */

:root,
.color - background - 1 {
    --color - foreground: var(--color - base - text);
    --color - background: var(--color - base - background - 1);
    --gradient - background: var(--gradient - base - background - 1);
}

.color - background - 2 {
    --color - background: var(--color - base - background - 2);
    --gradient - background: var(--gradient - base - background - 2);
}

.color - inverse {
    --color - foreground: var(--color - base - background - 1);
    --color - background: var(--color - base - text);
    --gradient - background: rgb(var(--color - base - text));
}

.color - accent - 1 {
    --color - foreground: var(--color - base - solid - button - labels);
    --color - background: var(--color - base - accent - 1);
    --gradient - background: var(--gradient - base - accent - 1);
}

.color - accent - 2 {
    --color - foreground: var(--color - base - solid - button - labels);
    --color - background: var(--color - base - accent - 2);
    --gradient - background: var(--gradient - base - accent - 2);
}

.color - foreground - outline - button {
    --color - foreground: var(--color - base - outline - button - labels);
}

.color - foreground - accent - 1 {
    --color - foreground: var(--color - base - accent - 1);
}

.color - foreground - accent - 2 {
    --color - foreground: var(--color - base - accent - 2);
}

:root,
.color - background - 1 {
    --color - link: var(--color - base - outline - button - labels);
    --alpha - link: 0.85;
}

.color - background - 2,
.color - inverse,
.color - accent - 1,
.color - accent - 2 {
    --color - link: var(--color - foreground);
    --alpha - link: 0.7;
}

:root,
.color - background - 1 {
    --color - button: var(--color - base - accent - 1);
    --color - button - text: var(--color - base - solid - button - labels);
    --alpha - button - background: 1;
    --alpha - button - border: 1;
}

.color - background - 2,
.color - inverse,
.color - accent - 1,
.color - accent - 2 {
    --color - button: var(--color - foreground);
    --color - button - text: var(--color - background);
}

.button--secondary
{
    --color - button: var(--color - base - outline - button - labels);
    --color - button - text: var(--color - base - outline - button - labels);
    --alpha - button - background: 0;
}

.color - background - 2.button--secondary,
.color - inverse.button--secondary,
.color - accent - 1.button--secondary,
.color - accent - 2.button--secondary
{
    --color - button: var(--color - foreground);
    --color - button - text: var(--color - foreground);
}

.button--tertiary
{
    --color - button: var(--color - base - outline - button - labels);
    --color - button - text: var(--color - base - outline - button - labels);
    --alpha - button - background: 0;
    --alpha - button - border: 0.2;
}

.color - background - 2.button--tertiary,
.color - inverse.button--tertiary,
.color - accent - 1.button--tertiary,
.color - accent - 2.button--tertiary
{
    --color - button: var(--color - foreground);
    --color - button - text: var(--color - foreground);
}

:root,
.color - background - 1 {
    --color - badge - background: var(--color - background);
    --color - badge - border: var(--color - foreground);
    --alpha - badge - border: 0.1;
}

.color - background - 2,
.color - inverse,
.color - accent - 1,
.color - accent - 2 {
    --color - badge - background: var(--color - background);
    --color - badge - border: var(--color - background);
    --alpha - badge - border: 1;
}

:root,
.color - background - 1,
.color - background - 2 {
    --color - card - hover: var(--color - base - text);
}

.color - inverse {
    --color - card - hover: var(--color - base - background - 1);
}

.color - accent - 1,
.color - accent - 2 {
    --color - card - hover: var(--color - base - solid - button - labels);
}

:root,
.color - icon - text {
    --color - icon: rgb(var(--color - base - text));
}

.color - icon - accent - 1 {
    --color - icon: rgb(var(--color - base - accent - 1));
}

.color - icon - accent - 2 {
    --color - icon: rgb(var(--color - base - accent - 2));
}

.color - icon - outline - button {
    --color - icon: rgb(var(--color - base - outline - button - labels));
}

/* base */

.no - js:not(html) {
display: none!important;
}

html.no - js.no - js:not(html) {
display: block!important;
}

.no - js - inline {
display: none!important;
}

html.no - js.no - js - inline {
display: inline - block!important;
}

html.no - js.no - js - hidden {
display: none!important;
}

.page - width {
    max - width: var(--page - width);
margin: 0 auto;
padding: 0 1.5rem;
}

.page - width - desktop {
padding: 0;
margin: 0 auto;
}

@media screen and (min-width: 750px) {
  .page - width {
    padding: 0 5rem;
    }

  .page - width--narrow {
    padding: 0 9rem;
    }

  .page - width - desktop {
    padding: 0;
    }
}

@media screen and (min-width: 990px) {
  .page - width--narrow {
        max - width: 72.6rem;
    padding: 0;
    }

  .page - width - desktop {
        max - width: var(--page - width);
    padding: 0 5rem;
    }
}

.element - margin {
    margin - top: 5rem;
}

.spaced - section {
    margin - top: 5rem;
}

.spaced - section:last - child {
    margin - bottom: 5rem;
}

.spaced - section--full - width + .spaced - section--full - width {
    margin - top: 0;
}

.spaced - section--full - width:first - child {
    margin - top: 0;
}

.spaced - section--full - width:last - child {
    margin - bottom: 0;
}

body,
.color - background - 1,
.color - background - 2,
.color - inverse,
.color - accent - 1,
.color - accent - 2 {
color: rgba(var(--color - foreground), 0.75);
    background - color: rgb(var(--color - background));
}

.background - secondary {
    background - color: rgba(var(--color - foreground), 0.04);
padding: 0rem 0 5rem;
}

@media screen and (min-width: 750px) {
  .background - secondary {
    padding: 0rem 0 5rem;
    }
}

.grid - auto - flow {
display: grid;
    grid - auto - flow: column;
}

.page - margin,
.shopify - challenge__container {
margin: 7rem auto;
}

.rte - width {
    max - width: 82rem;
margin: 0 auto 2rem;
}

.list - unstyled {
margin: 0;
padding: 0;
    list - style: none;
}

.hidden
{
display: none!important;
}

.visually - hidden {
position: absolute!important;
overflow: hidden;
width: 1px;
height: 1px;
margin: -1px;
padding: 0;
border: 0;
clip: rect(0 0 0 0);
    word - wrap: normal!important;
}

.visually - hidden--inline
{
margin: 0;
height: 1em;
}

.overflow - hidden {
overflow: hidden;
}

.skip - to - content - link:focus
{
    z - index: 9999;
position: inherit;
overflow: auto;
width: auto;
height: auto;
clip: auto;
}

.full - width - link {
position: absolute;
top: 0;
right: 0;
bottom: 0;
left: 0;
    z - index: 2;
}

h1,
h2,
h3,
h4,
h5,
.h0,
.h1,
.h2,
.h3,
.h4,
.h5
{
    font - family: var(--font - heading - family);
    font - style: var(--font - heading - style);
    font - weight: var(--font - heading - weight);
    letter - spacing: 0.06rem;
color: rgb(var(--color - foreground));
    line - height: 1.3;
}

.h0
{
    font - size: 4rem;
}

@media only screen and (min-width: 750px) {
  .h0 {
        font - size: 5.2rem;
    }
}

h1,
.h1
{
    font - size: 3rem;
}

@media only screen and (min-width: 750px) {
    h1,
  .h1 {
        font - size: 4rem;
    }
}

h2,
.h2
{
    font - size: 2rem;
}

@media only screen and (min-width: 750px) {
    h2,
  .h2 {
        font - size: 2.4rem;
    }
}

h3,
.h3
{
    font - size: 1.7rem;
}

@media only screen and (min-width: 750px) {
    h3,
  .h3 {
        font - size: 1.8rem;
    }
}

h4,
.h4
{
    font - family: var(--font - heading - family);
    font - style: var(--font - heading - style);
    font - size: 1.5rem;
}

h5,
.h5
{
    font - size: 1.2rem;
}

@media only screen and (min-width: 750px) {
    h5,
  .h5 {
        font - size: 1.3rem;
    }
}

h6,
.h6
{
color: rgba(var(--color - foreground), 0.75);
    margin - block - start: 1.67em;
    margin - block - end: 1.67em;
}

blockquote
{
    font - style: italic;
color: rgba(var(--color - foreground), 0.75);
    border - left: 0.2rem solid rgba(var(--color - foreground), 0.2);
    padding - left: 1rem;
}

@media screen and (min-width: 750px) {
    blockquote {
        padding - left: 1.5rem;
    }
}

.caption
{
    font - size: 1rem;
    letter - spacing: 0.07rem;
    line - height: 1.7;
}

@media screen and (min-width: 750px) {
  .caption {
        font - size: 1.2rem;
    }
}

.caption - with - letter - spacing {
    font - size: 1rem;
    letter - spacing: 0.13rem;
    line - height: 1.2;
    text - transform: uppercase;
}

.caption - large,
.customer.field input,
.customer select,
.field__input,
.form__label,
.select__select {
  font-size: 1.3rem;
line - height: 1.5;
letter - spacing: 0.04rem;
}

.color - foreground {
color: rgb(var(--color - foreground));
}

table: not([class]) {
    table - layout: fixed;
    border - collapse: collapse;
    font - size: 1.4rem;
    border - style: hidden;
    box - shadow: 0 0 0 0.1rem rgba(var(--color - foreground), 0.2);
    /* draws the table border  */
}

table: not([class]) td,
table: not([class]) th
{
padding: 1em;
border: 0.1rem solid rgba(var(--color - foreground), 0.2);
}

.hidden
{
display: none!important;
}

@media screen and (max-width: 749px) {
  .small - hide {
    display: none!important;
    }
}

@media screen and (min-width: 750px) and(max - width: 989px) {
  .medium - hide {
    display: none!important;
    }
}

@media screen and (min-width: 990px) {
  .large - up - hide {
    display: none!important;
    }
}

.center
{
    text - align: center;
}

.right
{
    text - align: right;
}

.uppercase
{
    text - transform: uppercase;
}

.light
{
opacity: 0.7;
}

a: empty,
ul: empty,
dl: empty,
div: empty,
section: empty,
article: empty,
p: empty,
h1: empty,
h2: empty,
h3: empty,
h4: empty,
h5: empty,
h6: empty {
display: none;
}

.link,
.customer a
{
    cursor: pointer;
    display: inline-block;
    border: none;
    box-shadow: none;
    text-decoration: underline;
    text-underline-offset: 0.3rem;
    color: rgb(var(--color-link));
    background-color: transparent;
    font-size: 1.4rem;
    font-family: inherit;
}

.link--text
{
color: rgb(var(--color - foreground));
}

.link--text: hover {
color: rgba(var(--color - foreground), 0.75);
}

.link - with - icon {
display: inline - flex;
    font - size: 1.4rem;
    font - weight: 600;
    letter - spacing: 0.1rem;
    text - decoration: none;
    margin - bottom: 4.5rem;
    white - space: nowrap;
}

.link - with - icon.icon {
width: 1.5rem;
    margin - left: 1rem;
}

.circle - divider::after {
content: '\2022';
margin: 0 1.3rem 0 1.5rem;
}

.circle - divider:last - of - type::after {
display: none;
}

hr
{
border: none;
height: 0.1rem;
    background - color: rgba(var(--color - foreground), 0.2);
display: block;
margin: 5rem 0;
}

@media screen and (min-width: 750px) {
    hr {
    margin: 7rem 0;
    }
}

.full - unstyled - link {
    text - decoration: none;
color: currentColor;
display: block;
}

.placeholder
{
    background - color: rgba(var(--color - foreground), 0.04);
color: rgba(var(--color - foreground), 0.55);
fill: rgba(var(--color - foreground), 0.55);
}

details > * {
    box - sizing: border - box;
}

.break {
    word -break: break-word;
}

.visibility - hidden {
visibility: hidden;
}

@media(prefers - reduced - motion) {
  .motion - reduce {
    transition: none!important;
    }
}

:root
{
    --duration - short: 100ms;
    --duration - default: 200ms;
    --duration - long: 500ms;
}

.underlined - link,
.customer a
{
    color: rgba(var(--color-link), var(--alpha-link));
    text-underline-offset: 0.3rem;
    text-decoration-thickness: 0.1rem;
    transition: text-decoration-thickness ease 100ms;
}

.underlined - link:hover,
.customer a:hover
{
color: rgb(var(--color - link));
    text - decoration - thickness: 0.2rem;
}

.icon - arrow {
width: 1.5rem;
}

/* arrow animation */
.animate - arrow.icon - arrow path
{
transform: translateX(-0.25rem);
transition: transform var(--duration - short) ease;
}

.animate - arrow:hover.icon - arrow path
{
transform: translateX(-0.05rem);
}

/* base-details-summary */
summary
{
cursor: pointer;
    list - style: none;
position: relative;
}

summary.icon - caret {
position: absolute;
height: 0.6rem;
right: 1.5rem;
top: calc(50 % -0.2rem);
}

summary::- webkit - details - marker {
display: none;
}

.disclosure - has - popup {
position: relative;
}

.disclosure - has - popup[open] > summary::before {
position: fixed;
    top: 0;
right: 0;
bottom: 0;
left: 0;
    z - index: 2;
display: block;
cursor: default;
content: ' ';
background: transparent;
}

.disclosure - has - popup > summary::before {
display: none;
}

.disclosure - has - popup[open] > summary + * {
    z - index: 100;
}

@media screen and (min-width: 750px) {
  .disclosure - has - popup[open] > summary + * {
        z - index: 2;
    }
}

/* base-focus */
/*
  Focus ring - default (with offset)
*/

*:focus
{
outline: 0;
    box - shadow: none;
}

*:focus - visible {
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: 0.3rem;
    box - shadow: 0 0 0 0.3rem rgb(var(--color - background)),
    0 0 0.5rem 0.4rem rgba(var(--color - foreground), 0.3);
}

/* Fallback - for browsers that don't support :focus-visible, a fallback is set for :focus */
.focused, .no - js *:focus
{
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: 0.3rem;
    box - shadow: 0 0 0 0.3rem rgb(var(--color - background)),
    0 0 0.5rem 0.4rem rgba(var(--color - foreground), 0.3);
}

/* Negate the fallback side-effect for browsers that support :focus-visible */
.no - js *:focus: not(:focus - visible) {
outline: 0;
    box - shadow: none;
}


/*
  Focus ring - inset
*/

.focus - inset:focus - visible {
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: -0.2rem;
    box - shadow: 0 0 0.2rem 0 rgba(var(--color - foreground), 0.3);
}

.focused.focus - inset, .no - js.focus - inset:focus
{
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: -0.2rem;
    box - shadow: 0 0 0.2rem 0 rgba(var(--color - foreground), 0.3);
}

.no - js.focus - inset:focus: not(:focus - visible) {
outline: 0;
    box - shadow: none;
}

/*
  Focus ring - none
*/

/* Dangerous for a11y - Use with care */
.focus - none {
    box - shadow: none!important;
outline: 0!important;
}

.focus - offset:focus - visible {
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: 1rem;
    box - shadow: 0 0 0 1rem rgb(var(--color - background)),
    0 0 0.2rem 1.2rem rgba(var(--color - foreground), 0.3);
}

.focus - offset.focused, .no - js.focus - offset:focus
{
outline: 0.2rem solid rgba(var(--color - foreground), 0.5);
    outline - offset: 1rem;
    box - shadow: 0 0 0 1rem rgb(var(--color - background)),
    0 0 0.2rem 1.2rem rgba(var(--color - foreground), 0.3);
}

.no - js.focus - offset:focus: not(:focus - visible) {
outline: 0;
    box - shadow: none;
}

/* component-title */
.title,
.title - wrapper - with - link {
margin: 3rem 0 2rem;
}

.title - wrapper - with - link.title {
margin: 0;
}

.title - wrapper {
    margin - bottom: 3rem;
}

.title - wrapper - with - link {
display: flex;
    justify - content: space - between;
    align - items: flex - end;
gap: 1rem;
margin: 4rem 0 3rem;
    flex - wrap: wrap;
}

.title--primary
{
margin: 4rem 0;
}

.title - wrapper--self - padded - tablet - down,
.title - wrapper--self - padded - mobile {
    padding - left: 1.5rem;
    padding - right: 1.5rem;
}

@media screen and (min-width: 750px) {
  .title - wrapper--self - padded - mobile {
        padding - left: 0;
        padding - right: 0;
    }
}

@media screen and (min-width: 990px) {
  .title,
  .title - wrapper - with - link {
    margin: 5rem 0 3rem;
    }

  .title--primary {
    margin: 2rem 0;
    }

  .title - wrapper - with - link {
        align - items: center;
    }

  .title - wrapper - with - link.title {
        margin - bottom: 0;
    }

  .title - wrapper--self - padded - tablet - down {
        padding - left: 0;
        padding - right: 0;
    }
}

.title - wrapper - with - link.link - with - icon {
margin: 0;
    flex - shrink: 0;
display: flex;
    align - items: center;
}

.title - wrapper - with - link.link - with - icon svg
{
width: 1.5rem;
}

.title - wrapper - with - link a
{
color: rgb(var(--color - link));
    margin - top: 0;
    flex - shrink: 0;
}

@media screen and (min-width: 990px) {
  .title - wrapper - with - link.title - wrapper - with - link--no - heading {
    display: none;
    }
}

.subtitle
{
    font - size: 1.8rem;
    line - height: 1.8;
    letter - spacing: 0.05rem;
color: rgba(var(--color - foreground), 0.7);
}

/* component-grid */
.grid
{
display: flex;
    flex - wrap: wrap;
    margin - bottom: 2rem;
    margin - left: -0.5rem;
padding: 0;
    list - style: none;
}

@media screen and (min-width: 750px) {
  .grid {
        margin - left: -1rem;
    }
}

.grid__item
{
    padding - left: 0.5rem;
    padding - bottom: 0.5rem;
width: calc(25 % -0.5rem * 3 / 4);
    max - width: 50 %;
    flex - grow: 1;
    flex - shrink: 0;
}

@media screen and (min-width: 750px) {
  .grid__item {
        padding - left: 1rem;
        padding - bottom: 1rem;
    width: calc(25 % -1rem * 3 / 4);
        max - width: 50 %;
    }
}

.grid--gapless.grid__item {
    padding - left: 0;
    padding - bottom: 0;
}

@media screen and (max-width: 749px) {
  .grid__item.slider__slide--full - width {
    width: 100 %;
        max - width: none;
    }
}

@media screen and (min-width: 750px) and(max - width: 989px) {
  .grid--one - third - max.grid--3 - col - tablet.grid__item {
        max - width: 33.33 %;
    }
}

@media screen and (min-width: 990px) {
  .grid--quarter - max.grid--4 - col - desktop.grid__item {
        max - width: 25 %;
    }
}

.grid--1 - col.grid__item {
    max - width: 100 %;
width: 100 %;
}

.grid--3 - col.grid__item {
width: calc(33.33 % -0.5rem * 2 / 3);
}

@media screen and (min-width: 750px) {
  .grid--3 - col.grid__item {
    width: calc(33.33 % -1rem * 2 / 3);
    }
}

.grid--2 - col.grid__item {
width: calc(50 % -0.5rem / 2);
}

@media screen and (min-width: 750px) {
  .grid--2 - col.grid__item {
    width: calc(50 % -1rem / 2);
    }

  .grid--4 - col - tablet.grid__item {
    width: calc(25 % -1rem * 3 / 4);
    }

  .grid--3 - col - tablet.grid__item {
    width: calc(33.33 % -1rem * 2 / 3);
    }

  .grid--2 - col - tablet.grid__item {
    width: calc(50 % -1rem / 2);
    }
}

@media screen and (min-width: 990px) {
  .grid--4 - col - desktop.grid__item {
    width: calc(25 % -1rem * 3 / 4);
    }

  .grid--3 - col - desktop.grid__item {
    width: calc(33.33 % -1rem * 2 / 3);
    }

  .grid--2 - col - desktop.grid__item {
    width: calc(50 % -1rem / 2);
    }
}

.grid__item--vertical - align {
    align - self: center;
}

.grid__item--full - width {
flex: 0 0 100 %;
    max - width: 100 %;
}

@media screen and (max-width: 749px) {
  .grid--peek.slider--mobile {
    margin: 0;
    width: 100 %;
    }

  .grid--peek.slider--mobile.grid__item {
        box - sizing: content - box;
    margin: 0;
    }

  .grid--peek.grid__item {
    width: calc(50 % -3.75rem / 2);
    }

  .grid--peek.grid__item:first - of - type {
        padding - left: 1.5rem;
    }

  .grid--peek.grid__item:last - of - type {
        padding - right: 1.5rem;
    }
}

@media screen and (min-width: 750px) and(max - width: 989px) {
  .slider--tablet.grid--peek.grid__item {
    width: calc(25 % -4rem * 3 / 4);
    }

  .slider--tablet.grid--peek.grid--3 - col - tablet.grid__item {
    width: calc(33.33 % -4rem * 2 / 3);
    }

  .slider--tablet.grid--peek.grid--2 - col - tablet.grid__item {
    width: calc(50 % -4rem / 2);
    }

  .slider--tablet.grid--peek.grid__item:first - of - type {
        padding - left: 1.5rem;
    }

  .slider--tablet.grid--peek.grid__item:last - of - type {
        padding - right: 1.5rem;
    }
}

@media screen and (max-width: 989px) {
  .slider--tablet.grid--peek {
    margin: 0;
    width: 100 %;
    }

  .slider--tablet.grid--peek.grid__item {
        box - sizing: content - box;
    margin: 0;
    }
}

/* component-media */
.media
{
display: block;
    background - color: rgba(var(--color - foreground), 0.1);
position: relative;
overflow: hidden;
}

.media--transparent
{
    background - color: transparent;
}

.media > *:not(.zoom, .deferred - media__poster - button),
.media model-viewer {
  display: block;
max - width: 100 %;
position: absolute;
top: 0;
left: 0;
height: 100 %;
width: 100 %;
}

.media > img {
    object-fit: cover;
    object-position: center center;
transition: opacity 0.4s cubic-bezier(0.25, 0.46, 0.45, 0.94);
}

.media--square
{
    padding - bottom: 100 %;
}

.media--portrait
{
    padding - bottom: 125 %;
}

.media--landscape
{
    padding - bottom: 66.6 %;
}

.media--cropped
{
    padding - bottom: 56 %;
}

.media--16 - 9 {
    padding - bottom: 56.25 %;
}

.media--circle
{
    padding - bottom: 100 %;
    border - radius: 50 %;
}

.media.media--hover - effect > img + img {
opacity: 0;
}

@media screen and (min-width: 990px) {
  .media--cropped {
        padding - bottom: 63 %;
    }
}

deferred - media {
display: block;
}

/* component-button */
/* Button - default */

.button,
.shopify - challenge__button,
.customer button
{
    cursor: pointer;
    display: inline-flex;
    justify-content: center;
    align-items: center;
    box-sizing: border-box;
    font: inherit;
    padding: 0.9rem 3rem 1.1rem;
    text-decoration: none;
    border: 0;
    border-radius: 0;
    background-color: rgba(var(--color-button), var(--alpha-button-background));
    box-shadow: 0 0 0 0.1rem rgba(var(--color-button), var(--alpha-button-border));
    color: rgb(var(--color-button-text));
    min-width: 12rem;
    min-height: 4.5rem;
    transition: box-shadow var(--duration-short) ease;
  -webkit-appearance: none;
    appearance: none;
}

.button: focus - visible {
    box - shadow: 0 0 0 0.1rem rgba(var(--color - button), var(--alpha - button - border)),
    0 0 0 0.3rem rgb(var(--color - background)),
    0 0 0.5rem 0.4rem rgba(var(--color - foreground), 0.3);
}

.button: focus {
    box - shadow: 0 0 0 0.1rem rgba(var(--color - button), var(--alpha - button - border)),
    0 0 0 0.3rem rgb(var(--color - background)),
    0 0 0.5rem 0.4rem rgba(var(--color - foreground), 0.3);
}

.button: focus: not(:focus - visible) {
    box - shadow: 0 0 0 0.1rem rgba(var(--color - button), var(--alpha - button - border));
}

.button,
.button - label,
.shopify - challenge__button,
.customer button
{
    font-size: 1.5rem;
    letter-spacing: 0.1rem;
    line-height: 1.2;
}

.button--tertiary
{
    font - size: 1.2rem;
padding: 1rem 1.5rem;
    min - width: 9rem;
    min - height: 3.5rem;
}

.button--small
{
padding: 1.2rem 2.6rem;
}

/* Button - hover */

.button: not([disabled]):hover,
.shopify - challenge__button:hover,
.customer button:hover
{
    box - shadow: 0 0 0 0.2rem rgba(var(--color - button), var(--alpha - button - border));
}

/* Button - other */

.button: disabled,
.button[aria - disabled = 'true'],
.button.disabled,
.customer button:disabled,
.customer button[aria - disabled = 'true'],
.customer button.disabled {
  cursor: not - allowed;
opacity: 0.5;
}

.button--full - width {
display: flex;
width: 100 %;
}

.button.loading {
color: transparent;
}

.button.loading:after
{
animation: loading var(--duration - long) infinite linear;
border: 0.5rem solid rgba(var(--color - button - text), 0.4);
    border - left: 0.5rem solid rgb(var(--color - button - text));
    border - radius: 100 %;
    box - sizing: content - box;
content: '';
display: block;
height: 2rem;
position: absolute;
width: 2rem;
}

@keyframes loading
{
  0% {
    transform: rotate(0deg);
    }
  100% {
    transform: rotate(360deg);
    }
}

/* Button - social share */

.share - button {
display: block;
position: relative;
}

.share - button details
{
width: fit - content;
}

.share - button__button {
    font - size: 1.4rem;
display: flex;
    min - height: 2.4rem;
    align - items: center;
color: rgba(var(--color - link), var(--alpha - link));
    margin - left: 0;
    padding - left: 0;
}

.share - button__button:hover,
details[open] > .share - button__button {
color: rgb(var(--color - link));
}

details[open] > .share - button__fallback {
animation: animateMenuOpen var(--duration - default) ease;
}

.share - button__button:hover
{
    text - decoration: underline;
    text - underline - offset: 0.3rem;
}

.share - button__button,
.share - button__fallback button
{
cursor: pointer;
    background - color: transparent;
border: none;
}

.share - button__button.icon - share {
    margin - right: 1rem;
}

.share - button__fallback {
background: rgb(var(--color - background));
display: flex;
    align - items: center;
position: absolute;
top: 3rem;
left: 0.1rem;
    z - index: 3;
width: 100 %;
    min - width: 31rem;
    box - shadow: 0 0 0 0.1rem rgba(var(--color - foreground), 0.55);
}

.share - button__fallback button
{
width: 4.4rem;
height: 4.4rem;
padding: 0;
    flex - shrink: 0;
display: flex;
    justify - content: center;
    align - items: center;
}

.share - button__fallback button: hover {
color: rgba(var(--color - foreground), 0.75);
}

.share - button__fallback button: hover svg {
transform: scale(1.07);
}

.share - button__close:not(.hidden) + .share - button__copy {
display: none;
}

.share - button__close,
.share - button__copy {
    background - color: transparent;
color: rgb(var(--color - foreground));
}

.share - button__fallback.field__input {
    box - shadow: none;
    text - overflow: ellipsis;
    white - space: nowrap;
overflow: hidden;
}

.share - button__fallback.icon {
width: 1.5rem;
height: 1.5rem;
}

.share - button__message:not(:empty) {
display: flex;
    align - items: center;
width: 100 %;
height: 100 %;
    margin - top: 0;
padding: 0.8rem 0 0.8rem 1.5rem;
}

.share - button__message:not(:empty):not(.hidden) ~* {
display: none;
}

/* component-form */
.field__input,
.select__select,
.customer.field input,
.customer select {
  -webkit-appearance: none;
appearance: none;
background - color: transparent;
border: 0;
border - radius: 0;
color: rgb(var(--color - foreground));
font - size: 1.6rem;
width: 100 %;
box - shadow: 0 0 0 0.1rem rgba(var(--color-foreground), 0.55);
height: 4.5rem;
box - sizing: border - box;
transition: box - shadow var(--duration - short) ease;
}

.select__select
{
    font - family: var(--font - body - family);
    font - style: var(--font - body - style);
    font - weight: var(--font - body - weight);
    font - size: 1.2rem;
color: rgba(var(--color - foreground), 0.75);
}

.field__input: hover,
.select__select: hover,
.customer.field input:hover,
.customer select:hover,
.localization - form__select:hover
{
    box - shadow: 0 0 0 0.2rem rgba(var(--color - foreground), 0.55);
}

.field__input: focus,
.select__select: focus,
.customer.field input:focus,
.customer select:focus,
.localization - form__select:focus
{
    box - shadow: 0 0 0 0.2rem rgba(var(--color - foreground), 0.75);
outline: transparent;
}

.text - area,
.select
{
display: inline - block;
position: relative;
width: 100 %;
}

/* Select */

.select.icon - caret,
.customer select + svg {
  height: 0.6rem;
pointer - events: none;
position: absolute;
top: calc(50 % -0.2rem);
right: 1.5rem;
}

.select__select,
.customer select
{
    cursor: pointer;
    line-height: 1.6;
    padding: 0 4rem 0 1.5rem;
}

/* Field */

.field
{
position: relative;
width: 100 %;
display: flex;
}

.customer.field {
display: block;
}

.field--with - error {
    flex - wrap: wrap;
}

.field__input,
.customer.field input
{
    flex-grow: 1;
    text-align: left;
    padding: 1.5rem;
}

.field__label,
.customer.field label
{
    font-size: 1.6rem;
    left: 1.5rem;
    top: 1rem;
    margin-bottom: 0;
    pointer-events: none;
    position: absolute;
    transition: top var(--duration-short) ease,
    font-size var(--duration-short) ease;
    color: rgba(var(--color-foreground), 0.75);
    letter-spacing: 0.1rem;
    line-height: 1.5;
}

.field__input: focus ~ .field__label,
.field__input: not(:placeholder - shown) ~ .field__label,
.field__input: -webkit - autofill ~ .field__label,
.customer.field input:focus ~label,
.customer.field input:not(:placeholder - shown) ~label,
.customer.field input:-webkit - autofill ~label {
    font - size: 1rem;
top: 0.3em;
    letter - spacing: 0.04rem;
}

.field__input: focus,
.field__input: not(:placeholder - shown),
.field__input: -webkit - autofill,
.customer.field input:focus,
.customer.field input:not(:placeholder - shown),
.customer.field input:-webkit - autofill {
padding: 2.2rem 1.5rem 0.8rem;
}

.field__input::- webkit - search - cancel - button,
.customer.field input::-webkit-search-cancel-button {
display: none;
}

.field__input::placeholder,
.customer.field input::placeholder
{
    opacity: 0;
}

.field__button
{
    align - items: center;
    background - color: transparent;
border: 0;
color: currentColor;
cursor: pointer;
display: flex;
height: 4.4rem;
    justify - content: center;
overflow: hidden;
padding: 0;
position: absolute;
right: 0;
top: 0;
width: 4.4rem;
}

.field__button > svg {
height: 2.5rem;
width: 2.5rem;
}

.field__input: -webkit - autofill ~ .field__button,
.field__input: -webkit - autofill ~ .field__label,
.customer.field input:-webkit - autofill ~label {
color: rgb(0, 0, 0);
}

/* Text area */

.text - area {
    font - family: var(--font - body - family);
    font - style: var(--font - body - style);
    font - weight: var(--font - body - weight);
padding: 1.2rem;
    min - height: 10rem;
resize: none;
}

.text - area--resize - vertical {
resize: vertical;
}

input[type = 'checkbox'] {
display: inline - block;
width: auto;
    margin - right: 0.5rem;
}

/* Form global */

.form__label
{
display: block;
    margin - bottom: 0.6rem;
}

.form__message
{
    align - items: center;
display: flex;
    font - size: 1.4rem;
    line - height: 1;
    margin - top: 1rem;
}

.form__message--large
{
    font - size: 1.6rem;
}

.customer.field.form__message {
    font - size: 1.4rem;
    text - align: left;
}

.form__message.icon,
.customer.form__message svg
{
    flex-shrink: 0;
    height: 1.3rem;
    margin-right: 0.5rem;
    width: 1.3rem;
}

.form__message--large.icon,
.customer.form__message svg
{
    height: 1.5rem;
    width: 1.5rem;
    margin-right: 1rem;
}

.customer.field.form__message svg
{
    align-self: start;
}

.form - status {
margin: 0;
    font - size: 1.6rem;
}

.form - status - list {
padding: 0;
margin: 2rem 0 4rem;
}

.form - status - list li
{
    list - style - position: inside;
}

.form - status - list.link::first - letter {
    text - transform: capitalize;
}

/* component-quantity */
.quantity
{
border: 0.1rem solid rgba(var(--color - base - text), 0.08);
position: relative;
height: 4.5rem;
width: 14rem;
display: flex;
}

.quantity__input
{
color: currentColor;
    font - size: 1.4rem;
    font - weight: 500;
opacity: 0.85;
    text - align: center;
    background - color: transparent;
border: 0;
padding: 0 0.5rem;
width: 100 %;
    flex - grow: 1;
    -webkit - appearance: none;
appearance: none;
}

.quantity__button
{
width: 4.5rem;
    flex - shrink: 0;
    font - size: 1.8rem;
border: 0;
    background - color: transparent;
cursor: pointer;
display: flex;
    align - items: center;
    justify - content: center;
color: rgb(var(--color - foreground));
padding: 0;
}

.quantity__button svg
{
    width: 1rem;
    pointer-events: none;
}

.quantity__input: -webkit - autofill,
.quantity__input: -webkit - autofill:hover,
.quantity__input: -webkit - autofill:active
{
    box - shadow: 0 0 0 10rem rgb(var(--color - background)) inset!important;
    -webkit - box - shadow: 0 0 0 10rem rgb(var(--color - background)) inset!important;
}

.quantity__input::- webkit - outer - spin - button,
.quantity__input::- webkit - inner - spin - button {
    -webkit - appearance: none;
margin: 0;
}

.quantity__input[type = 'number'] {
    -moz - appearance: textfield;
}

/* component-modal */
.modal__toggle
{
    list - style - type: none;
}

.no - js details[open].modal__toggle {
position: absolute;
    z - index: 2;
}

.modal__toggle - close {
display: none;
}

.no - js details[open] svg.modal__toggle - close {
display: flex;
    z - index: 1;
height: 1.7rem;
width: 1.7rem;
}

.modal__toggle - open {
display: flex;
}

.no - js details[open].modal__toggle - open {
display: none;
}

.no - js.modal__close - button.link {
display: none;
}

.modal__close - button.link {
display: flex;
    justify - content: center;
    align - items: center;
padding: 0rem;
height: 4.4rem;
width: 4.4rem;
    background - color: transparent;
}

.modal__close - button.icon {
width: 1.7rem;
height: 1.7rem;
}

.modal__content
{
position: absolute;
top: 0;
left: 0;
right: 0;
bottom: 0;
background: rgb(var(--color - background));
    z - index: 1;
display: flex;
    justify - content: center;
    align - items: center;
}

.media - modal {
cursor: zoom -out;
}

.media - modal.deferred - media {
cursor: initial;
}

/* component-cart-count-bubble */
.cart - count - bubble:empty
{
display: none;
}

.cart - count - bubble {
position: absolute;
    background - color: rgb(var(--color - button));
color: rgb(var(--color - button - text));
height: 1.7rem;
width: 1.7rem;
    border - radius: 100 %;
display: flex;
    justify - content: center;
    align - items: center;
    font - size: 0.9rem;
bottom: 0.8rem;
left: 2.2rem;
    line - height: 1.1;
}

/* section-announcement-bar */
# shopify-section-announcement-bar {
z - index: 4;
}

.announcement - bar {
    border - bottom: 0.1rem solid rgba(var(--color - foreground), 0.08);
color: rgb(var(--color - foreground));
}

.announcement - bar__link {
display: block;
width: 100 %;
padding: 1rem 2rem;
    text - decoration: none;
}

.announcement - bar__link:hover
{
color: rgb(var(--color - foreground));
    background - color: rgba(var(--color - card - hover), 0.06);
}

.announcement - bar__link.icon - arrow {
display: inline - block;
    pointer - events: none;
    margin - left: 0.8rem;
    vertical - align: middle;
    margin - bottom: 0.2rem;
}

.announcement - bar__link.announcement - bar__message {
padding: 0;
}

.announcement - bar__message {
    text - align: center;
padding: 1rem 2rem;
margin: 0;
    letter - spacing: 0.1rem;
}

/* section-header */
# shopify-section-header {
z - index: 3;
}

.shopify - section - header - sticky {
position: sticky;
top: 0;
}

.shopify - section - header - hidden {
transform: translateY(-100 %);
}

# shopify-section-header.animate {
transition: transform 0.15s ease-out;
}

/* Main Header Layout */
.header - wrapper {
display: block;
position: relative;
    background - color: rgb(var(--color - background));
}

.header - wrapper--border - bottom {
    border - bottom: 0.1rem solid rgba(var(--color - foreground), 0.08);
}

.header
{
display: grid;
    grid - template - areas: 'left-icon heading icons';
    grid - template - columns: 1fr 2fr 1fr;
    align - items: center;
    padding - top: 1rem;
    padding - bottom: 1rem;
}

@media screen and (min-width: 990px) {
  .header {
        padding - top: 2rem;
        padding - bottom: 2rem;
    }

  .header--has - menu:not(.header--middle - left) {
        padding - bottom: 0;
    }

  .header--top - left {
        grid - template - areas:
      'heading icons'
        'navigation navigation';
        grid - template - columns: 1fr auto;
    }

  .header--middle - left {
        grid - template - areas: 'heading navigation icons';
        grid - template - columns: auto 1fr auto;
        column - gap: 2rem;
    }

  .header--top - center {
        grid - template - areas:
      'left-icon heading icons'
        'navigation navigation navigation';
    }

  .header--middle - left.header__inline - menu {
        min - width: 45rem;
    }

  .header: not(.header--middle - left).header__inline - menu {
        margin - top: 1.05rem;
    }
}

.header *[tabindex = '-1']:focus
{
outline: none;
}

.header__heading
{
margin: 0;
    line - height: 0;
}

.header > .header__heading - link {
    line - height: 0;
}

.header__heading,
.header__heading - link {
    grid - area: heading;
    justify - self: center;
}

.header__heading - link {
display: inline - block;
padding: 0.75rem;
    text - decoration: none;
    word -break: break-word;
}

.header__heading - link:hover.h2 {
color: rgb(var(--color - foreground));
}

.header__heading - link.h2 {
    line - height: 1;
color: rgba(var(--color - foreground), 0.75);
}

.header__heading - logo {
height: auto;
width: 100 %;
}

@media screen and (min-width: 990px) {
  .header__heading - link {
        margin - left: -0.75rem;
    }

  .header__heading,
  .header__heading - link {
        justify - self: start;
    }

  .header--top - center.header__heading - link,
  .header--top - center.header__heading {
        justify - self: center;
    }
}

/* Header icons */
.header__icons
{
display: flex;
    grid - area: icons;
    justify - self: end;
}

.header__icon: not(.header__icon--summary),
.header__icon span
{
    display: flex;
    align-items: center;
    justify-content: center;
}

.header__icon span
{
    height: 100%;
}

.header__icon::after {
content: none;
}

.header__icon: hover.icon,
.modal__close - button:hover.icon {
transform: scale(1.07);
}

.header__icon.icon {
height: 2rem;
width: 2rem;
fill: none;
    vertical - align: middle;
}

.header__icon,
.header__icon--cart.icon {
height: 4.4rem;
width: 4.4rem;
}

.header__icon--cart
{
position: relative;
    margin - right: -1.2rem;
}

@media screen and (max-width: 989px) {
    menu - drawer ~ .header__icons.header__icon--account {
    display: none;
    }
}

/* Search */
menu - drawer + .header__search {
display: none;
}

.header > .header__search {
    grid - area: left - icon;
    justify - self: start;
}

.header: not(.header--has - menu) * > .header__search {
display: none;
}

.header__search
{
display: inline - flex;
    line - height: 0;
}

.header--top - center > .header__search {
display: none;
}

.header--top - center * > .header__search {
display: inline - flex;
}

@media screen and (min-width: 990px) {
  .header: not(.header--top - center) * > .header__search,
  .header--top - center > .header__search {
    display: inline - flex;
    }

  .header: not(.header--top - center) > .header__search,
  .header--top - center * > .header__search {
    display: none;
    }
}

.no - js.predictive - search {
display: none;
}

details[open] > .search - modal {
opacity: 1;
animation: animateMenuOpen var(--duration - default) ease;
}

details[open].modal - overlay {
display: block;
}

details[open].modal - overlay::after {
position: absolute;
content: '';
    background - color: rgb(var(--color - foreground), 0.5);
top: 100 %;
left: 0;
right: 0;
height: 100vh;
}

.no - js details[open] > .header__icon--search
{
top: 1rem;
right: 0.5rem;
}

.search - modal {
opacity: 0;
    border - bottom: 0.1rem solid rgba(var(--color - foreground), 0.08);
height: 100 %;
}

.search - modal__content {
display: flex;
    align - items: center;
    justify - content: center;
width: 100 %;
height: 100 %;
padding: 0 5rem 0 1rem;
    line - height: 1.8;
}

.search - modal__form {
width: 100 %;
}

.search - modal__close - button {
position: absolute;
right: 0.3rem;
}

@media screen and (min-width: 750px) {
  .search - modal__close - button {
    right: 1rem;
    }

  .search - modal__content {
    padding: 0 6rem;
    }
}

@media screen and (min-width: 990px) {
  .search - modal__form {
        max - width: 47.8rem;
    }

  .search - modal__close - button {
    position: initial;
        margin - left: 0.5rem;
    }
}

/* Header menu drawer */
.header__icon--menu.icon {
display: block;
position: absolute;
opacity: 1;
transform: scale(1);
transition: transform 150ms ease, opacity 150ms ease;
}

details: not([open]) > .header__icon--menu.icon - close,
details[open] > .header__icon--menu.icon - hamburger {
visibility: hidden;
opacity: 0;
transform: scale(0.8);
}

.js details[open]:not(.menu - opening) > .header__icon--menu.icon - close {
visibility: hidden;
}

.js details[open]:not(.menu - opening) > .header__icon--menu.icon - hamburger {
visibility: visible;
opacity: 1;
transform: scale(1.07);
}

.header__inline - menu details[open] > .header__submenu {
opacity: 1;
transform: translateY(0);
animation: animateMenuOpen var(--duration - default) ease;
}

/* Header menu */
.header__inline - menu {
    margin - left: -1.2rem;
    grid - area: navigation;
display: none;
}

.header--top - center.header__inline - menu,
.header--top - center.header__heading - link {
    margin - left: 0;
}

@media screen and (min-width: 990px) {
  .header__inline - menu {
    display: block;
    }

  .header--top - center.header__inline - menu {
        justify - self: center;
    }

  .header--top - center.header__inline - menu > .list - menu--inline {
        justify - content: center;
    }

  .header--middle - left.header__inline - menu {
        margin - left: 0;
    }
}

.header__menu
{
padding: 0 1rem;
}

.header__menu - item {
padding: 1.2rem;
    text - decoration: none;
color: rgba(var(--color - foreground), 0.75);
}

.header__menu - item:hover
{
color: rgb(var(--color - foreground));
}

.header__menu - item span
{
transition: text - decoration var(--duration - short) ease;
}

.header__menu - item:hover span
{
    text-decoration: underline;
    text-underline-offset: 0.3rem;
}

.header__active - menu - item {
transition: text - decoration - thickness var(--duration - short) ease;
color: rgb(var(--color - foreground));
    text - decoration: underline;
    text - underline - offset: 0.3rem;
}

.header__menu - item:hover.header__active - menu - item {
    text - decoration - thickness: 0.2rem;
}

.header__submenu
{
transition: opacity var(--duration - default) ease,
    transform var(--duration - default) ease;
}

.header__submenu.list - menu {
padding: 2rem 0;
}

.header__submenu.header__submenu {
    background - color: rgba(var(--color - foreground), 0.03);
padding: 0.5rem 0;
margin: 0.5rem 0;
}

.header__submenu.header__menu - item:after
{
right: 2rem;
}

.header__submenu.header__menu - item {
padding: 0.95rem 3.5rem 0.95rem 2rem;
}

.header__submenu.header__submenu.header__menu - item {
    padding - left: 3rem;
}

.header__menu - item.icon - caret {
right: 0.8rem;
}

.header__submenu.icon - caret {
right: 2rem;
}

details - disclosure > details {
position: relative;
}

@keyframes animateMenuOpen
{
  0% {
    opacity: 0;
    transform: translateY(-1.5rem);
    }

  100% {
    opacity: 1;
    transform: translateY(0);
    }
}

.overflow - hidden - mobile,
.overflow - hidden - tablet {
overflow: hidden;
}

@media screen and (min-width: 750px) {
  .overflow - hidden - mobile {
    overflow: auto;
    }
}

@media screen and (min-width: 990px) {
  .overflow - hidden - tablet {
    overflow: auto;
    }
}

.badge
{
border: 1px solid transparent;
    border - radius: 4rem;
display: inline - block;
    font - size: 1.2rem;
    letter - spacing: 0.1rem;
    line - height: 1;
padding: 0.6rem 1.3rem;
    text - align: center;
    background - color: rgb(var(--color - badge - background));
    border - color: rgba(var(--color - badge - border), var(--alpha - badge - border));
color: rgb(var(--color - foreground));
    word -break: break-word;
}

.gradient
{
background: var(--color - background);
background: var(--gradient - background);
    background - attachment: fixed;
}
