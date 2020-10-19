grammar Opg;

/*
 * Parser Rules
 */
file				: FileOpenTag fileContent FileCloseTag;
fileContent			: header headerExt? additionalSection* body additionalSection*;
legacySection		: header | headerExt | body;
additionalSection	: SectionOpenTag SectionCloseTag;
header				: HeaderOpenTag headerContent HeaderCloseTag;
headerExt			: HeaderExtOpenTag HeaderExtCloseTag;
body				: FloatingBodyTag* BodyOpenTag BodyCloseTag;
headerContent		: fileVersion;
fileVersion			: FileVersionTag FileVersionContent?;

/*
 * Lexer Rules
 */
FileOpenTag			: '<opimrtascii>';
FileCloseTag		: '</opimrtascii>';
HeaderOpenTag		: '<asciiheader>';
HeaderCloseTag		: '</asciiheader>';
HeaderExtOpenTag	: '<asciiheaderext>';
HeaderExtCloseTag	: '</asciiheaderext>';
BodyOpenTag			: '<body>';
BodyCloseTag		: '</body>';
SectionOpenTag		: '<section '.*?'>';
SectionCloseTag		: '</section>';
HeaderContent		: 'temp';
FloatingBodyTag		: 'temp2';
FileVersionTag		: 'File Version:';
FileVersionContent	: NUMBER;
WHITESPACE          : (' '|'\t')+ -> skip ;
NUMBER				: [0-9]+;
