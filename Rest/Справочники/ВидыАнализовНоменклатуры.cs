
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyAnalizovNomenklatury")]
	[Route("/Catalogs/VidyAnalizovNomenklatury/{Code}")]
	public class VidyAnalizovNomenklaturyRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<VidyAnalizovNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyAnalizovNomenklaturyResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyAnalizovNomenklaturys")]
	[Route("/Catalogs/VidyAnalizovNomenklaturys/{Codes}")]
	public class VidyAnalizovNomenklaturysRequest/*������������������������������*/: IReturn<List<VidyAnalizovNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyAnalizovNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyAnalizovNomenklaturysResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class VidyAnalizovNomenklaturyService /*������������������������������*/ : Service
	{
		public object Any(VidyAnalizovNomenklaturyRequest request)
		{
			return new VidyAnalizovNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyAnalizovNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyAnalizovNomenklaturyResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(VidyAnalizovNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
