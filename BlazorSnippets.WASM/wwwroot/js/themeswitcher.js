export function ChangeTheme(updateThemeLink) {
    let oldLink = document.getElementById('blazorSnippetTheme');

    if (oldLink.getAttribute('href') == updateThemeLink) {
        return;
    }

    let newLink = document.createElement('link');
    newLink.setAttribute('id', 'blazorSnippetTheme');
    newLink.setAttribute('rel', 'stylesheet');   
    newLink.setAttribute('href', updateThemeLink);
    newLink.onload = () => {
        oldLink.parentElement.removeChild(oldLink);
    }

    document.head.appendChild(newLink);

}