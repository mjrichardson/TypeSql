//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g 2012-12-13 18:17:20

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
internal partial class TypeSqlLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int ANY=4;
	public const int DIGIT=5;
	public const int ID=6;
	public const int INPUT_TOKEN=7;
	public const int NEWLINE=8;
	public const int OUTPUT_TOKEN=9;
	public const int SQL=10;
	public const int WHITESPACE=11;

    // delegates
    // delegators

	public TypeSqlLexer()
	{
		OnCreated();
	}

	public TypeSqlLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public TypeSqlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__12();
	partial void LeaveRule_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		EnterRule_T__12();
		EnterRule("T__12", 1);
		TraceIn("T__12", 1);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:9:7: ( ':' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:9:9: ':'
			{
			DebugLocation(9, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 1);
			LeaveRule("T__12", 1);
			LeaveRule_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void EnterRule_T__13();
	partial void LeaveRule_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		EnterRule_T__13();
		EnterRule("T__13", 2);
		TraceIn("T__13", 2);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:10:7: ( '@' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:10:9: '@'
			{
			DebugLocation(10, 9);
			Match('@'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 2);
			LeaveRule("T__13", 2);
			LeaveRule_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void EnterRule_T__14();
	partial void LeaveRule_T__14();

	// $ANTLR start "T__14"
	[GrammarRule("T__14")]
	private void mT__14()
	{
		EnterRule_T__14();
		EnterRule("T__14", 3);
		TraceIn("T__14", 3);
		try
		{
			int _type = T__14;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:11:7: ( '[' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:11:9: '['
			{
			DebugLocation(11, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__14", 3);
			LeaveRule("T__14", 3);
			LeaveRule_T__14();
		}
	}
	// $ANTLR end "T__14"

	partial void EnterRule_T__15();
	partial void LeaveRule_T__15();

	// $ANTLR start "T__15"
	[GrammarRule("T__15")]
	private void mT__15()
	{
		EnterRule_T__15();
		EnterRule("T__15", 4);
		TraceIn("T__15", 4);
		try
		{
			int _type = T__15;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:12:7: ( ']' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:12:9: ']'
			{
			DebugLocation(12, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__15", 4);
			LeaveRule("T__15", 4);
			LeaveRule_T__15();
		}
	}
	// $ANTLR end "T__15"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 5);
		TraceIn("ID", 5);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:48:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | DIGIT | '_' )* )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:49:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | DIGIT | '_' )*
			{
			DebugLocation(49, 2);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(49, 26);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:49:26: ( 'a' .. 'z' | 'A' .. 'Z' | DIGIT | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:
					{
					DebugLocation(49, 26);
					input.Consume();


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 5);
			LeaveRule("ID", 5);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_DIGIT();
	partial void LeaveRule_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		EnterRule_DIGIT();
		EnterRule("DIGIT", 6);
		TraceIn("DIGIT", 6);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:52:17: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:
			{
			DebugLocation(52, 17);
			if ((input.LA(1)>='0' && input.LA(1)<='9'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("DIGIT", 6);
			LeaveRule("DIGIT", 6);
			LeaveRule_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void EnterRule_NEWLINE();
	partial void LeaveRule_NEWLINE();

	// $ANTLR start "NEWLINE"
	[GrammarRule("NEWLINE")]
	private void mNEWLINE()
	{
		EnterRule_NEWLINE();
		EnterRule("NEWLINE", 7);
		TraceIn("NEWLINE", 7);
		try
		{
			int _type = NEWLINE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:56:9: ( ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:57:2: ( '\\r' )? '\\n'
			{
			DebugLocation(57, 2);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:57:2: ( '\\r' )?
			int alt2=2;
			try { DebugEnterSubRule(2);
			try { DebugEnterDecision(2, false);
			int LA2_0 = input.LA(1);

			if ((LA2_0=='\r'))
			{
				alt2 = 1;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:57:2: '\\r'
				{
				DebugLocation(57, 2);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(2); }

			DebugLocation(57, 8);
			Match('\n'); 
			DebugLocation(57, 12);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEWLINE", 7);
			LeaveRule("NEWLINE", 7);
			LeaveRule_NEWLINE();
		}
	}
	// $ANTLR end "NEWLINE"

	partial void EnterRule_WHITESPACE();
	partial void LeaveRule_WHITESPACE();

	// $ANTLR start "WHITESPACE"
	[GrammarRule("WHITESPACE")]
	private void mWHITESPACE()
	{
		EnterRule_WHITESPACE();
		EnterRule("WHITESPACE", 8);
		TraceIn("WHITESPACE", 8);
		try
		{
			int _type = WHITESPACE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:60:13: ( ( ' ' | '\\t' )+ )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:60:17: ( ' ' | '\\t' )+
			{
			DebugLocation(60, 17);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:60:17: ( ' ' | '\\t' )+
			int cnt3=0;
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_0 = input.LA(1);

				if ((LA3_0=='\t'||LA3_0==' '))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:
					{
					DebugLocation(60, 17);
					input.Consume();


					}
					break;

				default:
					if (cnt3 >= 1)
						goto loop3;

					EarlyExitException eee3 = new EarlyExitException( 3, input );
					DebugRecognitionException(eee3);
					throw eee3;
				}
				cnt3++;
			}
			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(60, 29);
			_channel = Hidden;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHITESPACE", 8);
			LeaveRule("WHITESPACE", 8);
			LeaveRule_WHITESPACE();
		}
	}
	// $ANTLR end "WHITESPACE"

	partial void EnterRule_ANY();
	partial void LeaveRule_ANY();

	// $ANTLR start "ANY"
	[GrammarRule("ANY")]
	private void mANY()
	{
		EnterRule_ANY();
		EnterRule("ANY", 9);
		TraceIn("ANY", 9);
		try
		{
			int _type = ANY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:63:6: ( . )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:63:8: .
			{
			DebugLocation(63, 8);
			MatchAny(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ANY", 9);
			LeaveRule("ANY", 9);
			LeaveRule_ANY();
		}
	}
	// $ANTLR end "ANY"

	public override void mTokens()
	{
		// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:8: ( T__12 | T__13 | T__14 | T__15 | ID | NEWLINE | WHITESPACE | ANY )
		int alt4=8;
		try { DebugEnterDecision(4, false);
		int LA4_0 = input.LA(1);

		if ((LA4_0==':'))
		{
			alt4 = 1;
		}
		else if ((LA4_0=='@'))
		{
			alt4 = 2;
		}
		else if ((LA4_0=='['))
		{
			alt4 = 3;
		}
		else if ((LA4_0==']'))
		{
			alt4 = 4;
		}
		else if (((LA4_0>='A' && LA4_0<='Z')||LA4_0=='_'||(LA4_0>='a' && LA4_0<='z')))
		{
			alt4 = 5;
		}
		else if ((LA4_0=='\r'))
		{
			int LA4_6 = input.LA(2);

			if ((LA4_6=='\n'))
			{
				alt4 = 6;
			}
			else
			{
				alt4 = 8;
			}
		}
		else if ((LA4_0=='\n'))
		{
			alt4 = 6;
		}
		else if ((LA4_0=='\t'||LA4_0==' '))
		{
			alt4 = 7;
		}
		else if (((LA4_0>='\u0000' && LA4_0<='\b')||(LA4_0>='\u000B' && LA4_0<='\f')||(LA4_0>='\u000E' && LA4_0<='\u001F')||(LA4_0>='!' && LA4_0<='9')||(LA4_0>=';' && LA4_0<='?')||LA4_0=='\\'||LA4_0=='^'||LA4_0=='`'||(LA4_0>='{' && LA4_0<='\uFFFF')))
		{
			alt4 = 8;
		}
		else
		{
			NoViableAltException nvae = new NoViableAltException("", 4, 0, input);
			DebugRecognitionException(nvae);
			throw nvae;
		}
		} finally { DebugExitDecision(4); }
		switch (alt4)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:10: T__12
			{
			DebugLocation(1, 10);
			mT__12(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:16: T__13
			{
			DebugLocation(1, 16);
			mT__13(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:22: T__14
			{
			DebugLocation(1, 22);
			mT__14(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:28: T__15
			{
			DebugLocation(1, 28);
			mT__15(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:34: ID
			{
			DebugLocation(1, 34);
			mID(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:37: NEWLINE
			{
			DebugLocation(1, 37);
			mNEWLINE(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:45: WHITESPACE
			{
			DebugLocation(1, 45);
			mWHITESPACE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\ANTLR\\TypeSql.g:1:56: ANY
			{
			DebugLocation(1, 56);
			mANY(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}
