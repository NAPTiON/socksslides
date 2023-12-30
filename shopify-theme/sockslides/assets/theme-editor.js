const selectVariantByClickingImage = {
  // Create variant images from productJson object
  _createVariantImage: function (product) {
    const variantImageObject = {};
    product.variants.forEach((variant) => {
      if (typeof variant.featured_image !== 'undefined' && variant.featured_image !== null) {
        const variantImage = variant.featured_image.src
          .split('?')[0]
          .replace(/http(s)?:/, '');
        variantImageObject[variantImage] = variantImageObject[variantImage] || {};
        product.options.forEach((option, index) => {
          const optionValue = variant.options[index];
          const optionKey = `option-${index}`;
          if (typeof variantImageObject[variantImage][optionKey] === 'undefined') {
            variantImageObject[variantImage][optionKey] = optionValue;
          } else {
            const oldValue = variantImageObject[variantImage][optionKey];
            if (oldValue !== null && oldValue !== optionValue) {
              variantImageObject[variantImage][optionKey] = optionValue;
            }
          }
        });
      }
    });
    return variantImageObject;
  },
  _updateVariant: function (event, id, product, variantImages) {
    const arrImage = event.src
      .split('?')[0]
      .replace(/http(s)?:/, '')
      .split('.');
    const strExtention = arrImage.pop();
    const strRemaining = arrImage.pop();
    const strNewImage = `${arrImage.join('.')}.${strRemaining}.${strExtention}`;
    
    if (typeof variantImages[strNewImage] !== 'undefined') {
      product.variants.forEach((option, index) => {
        const optionValue = variantImages[strNewImage][`option-${index}`];
        if (optionValue !== null && optionValue !== undefined) {
          const selects = document.querySelectorAll('#'+ id + ' [class*=select__select]');
          const options = selects[index].options;
          for (let option, n = 0; (option = options[n]); n += 1) {
            if (option.value === optionValue) {
              selects[index].selectedIndex = n;
              selects[index].dispatchEvent(new Event('change'));
              break;
            }
          }
        }
      });
    }
  },
  _selectVariant: function() {
    const productJson = document.querySelectorAll('[id^=ProductJson-');
    if (productJson.length > 0) {
      productJson.forEach((product) => {
        const sectionId = product.id.replace("ProductJson-", "MainProduct-");
        const thumbnails = document.querySelectorAll('#'+ sectionId + ' .thumbnail img');
        if (thumbnails.length > 1) {
          const productObject = JSON.parse(product.innerHTML);
          const variantImages = this._createVariantImage(productObject);
          var _this = this;
          document.addEventListener('click', function(e) {
              e = e || window.event;
              var target = e.target;
            if(target.classList.contains('thumbnail')){
              _this._updateVariant(target.querySelector('img'), sectionId, productObject, variantImages)
            }
          }, false);
        }
      });
    }
  },
};
if (document.readyState !== 'loading') {
  selectVariantByClickingImage._selectVariant();
} else {
  document.addEventListener(
    'DOMContentLoaded',
    selectVariantByClickingImage._selectVariant(),
  );
}