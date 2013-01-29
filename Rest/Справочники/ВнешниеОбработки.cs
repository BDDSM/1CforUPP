
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VneshnieObrabotki")]
	[Route("/Catalogs/VneshnieObrabotki/{Code}")]
	public class VneshnieObrabotkiRequest/*����������������������*/: V82.�����������������.����������������,IReturn<VneshnieObrabotkiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VneshnieObrabotkiResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VneshnieObrabotkis")]
	[Route("/Catalogs/VneshnieObrabotkis/{Codes}")]
	public class VneshnieObrabotkisRequest/*����������������������*/: IReturn<List<VneshnieObrabotkiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VneshnieObrabotkisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VneshnieObrabotkisResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class VneshnieObrabotkiService /*����������������������*/ : Service
	{
		public object Any(VneshnieObrabotkiRequest request)
		{
			return new VneshnieObrabotkiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VneshnieObrabotkiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new VneshnieObrabotkiResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(VneshnieObrabotkisRequest request)
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
