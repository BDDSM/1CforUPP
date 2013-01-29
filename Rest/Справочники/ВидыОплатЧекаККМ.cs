
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyOplatCHekaKKM")]
	[Route("/Catalogs/VidyOplatCHekaKKM/{Code}")]
	public class VidyOplatCHekaKKMRequest/*����������������������*/: V82.�����������������.����������������,IReturn<VidyOplatCHekaKKMRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyOplatCHekaKKMResponse//���������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyOplatCHekaKKMs")]
	[Route("/Catalogs/VidyOplatCHekaKKMs/{Codes}")]
	public class VidyOplatCHekaKKMsRequest/*����������������������*/: IReturn<List<VidyOplatCHekaKKMRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyOplatCHekaKKMsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyOplatCHekaKKMsResponse//���������������������
	{
		public string Result {get;set;}
	}


	public class VidyOplatCHekaKKMService /*����������������������*/ : Service
	{
		public object Any(VidyOplatCHekaKKMRequest request)
		{
			return new VidyOplatCHekaKKMResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyOplatCHekaKKMRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������.�����������(���������);
				if (������ == null)
				{
					return new VidyOplatCHekaKKMResponse() {Result = "���������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������.�����������(1);
			}
		}

		public object Get(VidyOplatCHekaKKMsRequest request)
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
