
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyDiskontnykhKart")]
	[Route("/Catalogs/VidyDiskontnykhKart/{Code}")]
	public class VidyDiskontnykhKartRequest/*������������������������*/: V82.�����������������.������������������,IReturn<VidyDiskontnykhKartRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyDiskontnykhKartResponse//�����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyDiskontnykhKarts")]
	[Route("/Catalogs/VidyDiskontnykhKarts/{Codes}")]
	public class VidyDiskontnykhKartsRequest/*������������������������*/: IReturn<List<VidyDiskontnykhKartRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyDiskontnykhKartsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyDiskontnykhKartsResponse//�����������������������
	{
		public string Result {get;set;}
	}


	public class VidyDiskontnykhKartService /*������������������������*/ : Service
	{
		public object Any(VidyDiskontnykhKartRequest request)
		{
			return new VidyDiskontnykhKartResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyDiskontnykhKartRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyDiskontnykhKartResponse() {Result = "������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������.�����������(1);
			}
		}

		public object Get(VidyDiskontnykhKartsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������.�����������(���������);
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
