import hljs from '../highlight/es/highlight.js';
import csharp from '../highlight/es/languages/csharp.min.js';
hljs.registerLanguage('csharp', csharp);
import cshtml from '../highlight/es/languages/cshtml-razor.min.js';
hljs.registerLanguage('cshtml', cshtml);
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
    var options = {
        // the selector for the badge template
        templateSelector: "#CodeBadgeTemplate",
        // base content selector that is searched for snippets
        contentSelector: "body",
        // Delay in ms used for `setTimeout` before badging is applied
        // Use if you need to time highlighting and badge application
        // since the badges need to be applied afterwards.
        // 0 - direct execution (ie. you handle timing
        loadDelay: 0,
        // CSS class(es) used to render the copy icon.
        copyIconClass: "fa fa-copy",
        // optional content for icons class (<i class="fa fa-copy"></i> or <i class="material-icons">file_copy</i>)
        copyIconContent: "",
        // CSS class(es) used to render the done icon.
        checkIconClass: "fa fa-check text-success",
        checkIconContent: "",
        // function called before code is placed on clipboard
        // Passed in text and returns back text function(text, codeElement) { return text; }
        onBeforeCodeCopied: null
    };
}
//# sourceMappingURL=codesnippets.js.map