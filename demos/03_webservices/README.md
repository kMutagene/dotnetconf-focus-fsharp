In this demo, i showed a web service we are running to host an Excel add-in, [SWATE](https://github.com/nfdi4plants/Swate).

It is a webservice designed for using the [office.js](https://github.com/OfficeDev/office-js) javascript API for Excel to support researchers in annotating their experimental research with metadata.

You can check out SWATE by sideloading (this means that you are using a third party office add in that has not been screened by the usual microsoft store procedures, just to make this clear.) the add-in. To do that, first install node.js and then execute the `swate.cmd` or `swate.sh` scripts. Another approach can be opening a blank sheet in excel online, and inserting the add-in by uploading the `manifest.xml` file contained in this folder (via Insert -> Add-In -> upload).

## Additional Links

There were multiple talks about web programming in F# on this conference that give better introduction and references for web programming with F#, but here are the top dogs anyways:

- [SAFE Stack](https://github.com/SAFE-Stack?type=source) ([docs](https://safe-stack.github.io/docs/))
- [Fable](https://github.com/fable-compiler/Fable) ([docs](https://fable.io/))