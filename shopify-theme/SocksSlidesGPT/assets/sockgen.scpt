JsOsaDAS1.001.00bplist00�Vscript_T// assets/your-script.js

const sockContainer = document.getElementById('sock-container');
const unsplashApiUrl = 'https://source.unsplash.com/featured/?sock';

function generateRandomSock() {
    const randomSock = `${unsplashApiUrl}&${new Date().getTime()}`;
    sockContainer.innerHTML = `<img src="${randomSock}" alt="Random Sock">`;
}
                              jjscr  ��ޭ