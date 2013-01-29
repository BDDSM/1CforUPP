
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/IstochnikiInformaciiPriObrashheniiPokupatelejj")]
	[Route("/Catalogs/IstochnikiInformaciiPriObrashheniiPokupatelejj/{Code}")]
	public class IstochnikiInformaciiPriObrashheniiPokupatelejjRequest/*������������������������������������������������*/: V82.�����������������.������������������������������������������,IReturn<IstochnikiInformaciiPriObrashheniiPokupatelejjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class IstochnikiInformaciiPriObrashheniiPokupatelejjResponse//�����������������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/IstochnikiInformaciiPriObrashheniiPokupatelejjs")]
	[Route("/Catalogs/IstochnikiInformaciiPriObrashheniiPokupatelejjs/{Codes}")]
	public class IstochnikiInformaciiPriObrashheniiPokupatelejjsRequest/*������������������������������������������������*/: IReturn<List<IstochnikiInformaciiPriObrashheniiPokupatelejjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public IstochnikiInformaciiPriObrashheniiPokupatelejjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class IstochnikiInformaciiPriObrashheniiPokupatelejjsResponse//�����������������������������������������������
	{
		public string Result {get;set;}
	}


	public class IstochnikiInformaciiPriObrashheniiPokupatelejjService /*������������������������������������������������*/ : Service
	{
		public object Any(IstochnikiInformaciiPriObrashheniiPokupatelejjRequest request)
		{
			return new IstochnikiInformaciiPriObrashheniiPokupatelejjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(IstochnikiInformaciiPriObrashheniiPokupatelejjRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������������������������.�����������(���������);
				if (������ == null)
				{
					return new IstochnikiInformaciiPriObrashheniiPokupatelejjResponse() {Result = "������������������������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������������������������.�����������(1);
			}
		}

		public object Get(IstochnikiInformaciiPriObrashheniiPokupatelejjsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
