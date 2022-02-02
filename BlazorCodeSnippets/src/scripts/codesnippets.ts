﻿import hljs from '../highlight/es/highlight.js';


import csharp from '../highlight/es/languages/csharp.min.js';
hljs.registerLanguage('csharp', csharp);

import cpp from '../highlight/es/languages/cpp.min.js';
hljs.registerLanguage('cpp', cpp);

import docker from '../highlight/es/languages/dockerfile.min.js';
hljs.registerLanguage('docker', docker);

import django from '../highlight/es/languages/django.min.js';
hljs.registerLanguage('django', django);

import cshtml from '../highlight/es/languages/cshtml-razor.min.js';
hljs.registerLanguage('cshtml', cshtml);

import erlang from '../highlight/es/languages/erlang.min.js';
hljs.registerLanguage('erlang', erlang);

import gcode from '../highlight/es/languages/gcode.min.js';
hljs.registerLanguage('gcode', gcode);

import go from '../highlight/es/languages/go.min.js';
hljs.registerLanguage('go', go);

import java from '../highlight/es/languages/java.min.js';
hljs.registerLanguage('java', java);

import kotlin from '../highlight/es/languages/kotlin.min.js';
hljs.registerLanguage('kotlin', kotlin);

import nginx from '../highlight/es/languages/nginx.min.js';
hljs.registerLanguage('nginx', nginx);

import objectivec from '../highlight/es/languages/objectivec.min.js';
hljs.registerLanguage('objectivec', objectivec);

import php from '../highlight/es/languages/php.min.js';
hljs.registerLanguage('php', php);

import perl from '../highlight/es/languages/perl.min.js';
hljs.registerLanguage('perl', perl);

import python from '../highlight/es/languages/python.min.js';
hljs.registerLanguage('python', python);

import razor from '../highlight/es/languages/cshtml-razor.min.js';
hljs.registerLanguage('razor', razor);

import fsharp from '../highlight/es/languages/fsharp.min.js';
hljs.registerLanguage('fsharp', fsharp);

import excel from '../highlight/es/languages/excel.min.js';
hljs.registerLanguage('excel', excel);

import http from '../highlight/es/languages/http.min.js';
hljs.registerLanguage('http', http);

import html from '../highlight/es/languages/xml.min.js';
hljs.registerLanguage('html', html);

import javascript from '../highlight/es/languages/javascript.min.js';
hljs.registerLanguage('javascript', javascript);

import json from '../highlight/es/languages/less.min.js';
hljs.registerLanguage('json', json);

import less from '../highlight/es/languages/less.min.js';
hljs.registerLanguage('less', less);

import markdown from '../highlight/es/languages/markdown.min.js';
hljs.registerLanguage('markdown', markdown);

import powershell from '../highlight/es/languages/powershell.min.js';
hljs.registerLanguage('powershell', powershell);

import plaintext from '../highlight/es/languages/plaintext.min.js';
hljs.registerLanguage('plaintext', plaintext);


import scss from '../highlight/es/languages/scss.min.js';
hljs.registerLanguage('scss', scss);

import sql from '../highlight/es/languages/sql.min.js';
hljs.registerLanguage('sql', sql);

import tsql from '../highlight/es/languages/tsql.min.js';
hljs.registerLanguage('tsql', tsql);


import typescript from '../highlight/es/languages/typescript.min.js';
hljs.registerLanguage('typescript', typescript);

import vbnet from '../highlight/es/languages/vbnet.min.js';
hljs.registerLanguage('vbnet', vbnet);

import vbscript from '../highlight/es/languages/vbscript.min.js';
hljs.registerLanguage('vbscript', vbscript);

import yaml from '../highlight/es/languages/yaml.min.js';
hljs.registerLanguage('yaml', yaml);


export function highlightSnippet() {

    document.querySelectorAll('pre code').forEach((el) => {
        hljs.highlightElement(el);
    });    
}

export function copyToClipboard() {   

    let buttonText = document.querySelector(".button-text"); 

    buttonText.innerHTML = 'Copied';

    setTimeout(function () {
        buttonText.innerHTML = 'Copy';
    }, 1000)

    let code = document.querySelector('pre>code');
    let text = code.textContent || code.innerHTML;

    console.log(text);

    let copiedText = document.createElement('textarea');
    copiedText.value = text.trim();
    document.body.appendChild(copiedText);
    copiedText.style.display = "block";

    copiedText.select();

    document.execCommand('copy');

    document.body.removeChild(copiedText);
}