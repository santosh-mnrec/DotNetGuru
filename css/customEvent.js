Blazor.registerCustomEventType('dotnetguruevent', {
  browserEventName: 'paste',
  createEventArgs: event => {
    let isMedia = false;
    let data = event.clipboardData.getData('Text');
    const items = event.clipboardData.items;
    const acceptedMim = ['iamge/png'];
    for (let i = 0; i < items.length; i++) {
      const file = items[i].getAsFile();
      if (!file) continue;
      if (acceptedMim.indexOf(items[i].type) != -1) {
        continue;

      }
      isMedia = true;
      const url = window.URL;
      data = url.createObjectURL(file);
      return {
        isMedia,
        data
      }
    }

  }
});