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

export function SetInitialTheme(elementId){

    let dropdown = document.getElementById(elementId);
    let currentTheme = document.getElementById('blazorSnippetTheme');
    let value = currentTheme.getAttribute('href');

    dropdown.value = value;

}