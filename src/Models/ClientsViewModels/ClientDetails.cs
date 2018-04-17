using System.Collections.Generic;
using GoldenTicket.Models;

namespace GoldenTicket.Models.ClientsViewModels
{
    /// <summary>
    /// Client details request model
    /// </summary>
    public class ClientDetails
    {
        /// <summary>
        /// Get's client
        /// </summary>
        /// <returns>the client</returns>
        public Client Client { get; set; }

        /// <summary>
        /// List of tickets associated with client
        /// </summary>
        /// <returns>client's ticket list</returns>
        public List<Ticket> Tickets { get; set; }
    }
}