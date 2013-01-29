
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyNomenklatury")]
	[Route("/Catalogs/VidyNomenklatury/{Code}")]
	public class VidyNomenklaturyRequest/*����������������������*/: V82.�����������������.����������������,IReturn<VidyNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyNomenklaturyResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyNomenklaturys")]
	[Route("/Catalogs/VidyNomenklaturys/{Codes}")]
	public class VidyNomenklaturysRequest/*����������������������*/: IReturn<List<VidyNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyNomenklaturysResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class VidyNomenklaturyService /*����������������������*/ : Service
	{
		public object Any(VidyNomenklaturyRequest request)
		{
			return new VidyNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyNomenklaturyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new VidyNomenklaturyResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(VidyNomenklaturysRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������.�����������(���������);
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
